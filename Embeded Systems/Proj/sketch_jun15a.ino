#include <WiFi.h>
#include <PubSubClient.h>
#include <DHT.h>
#include <ZMPT101B.h>

// Define sensor types
#define DHTTYPE DHT11
#define SENSITIVITY 664.0f

// Replace with your network credentials
const char* ssid = "AndroidAP5E74";
const char* password = "123456789";

// Replace with your MQTT broker IP address
const char* mqtt_server = "mqtt_broker_IP";

// Replace with your MQTT topic
const char* mqtt_topic = "your_topic";


// Pin connections 
const int voltagePin = 33;  // Analog input pin for voltage (A0)
const int currentPin = 32;  // Analog input pin for current (A1)
const int dhtPin = 4;  // Digital input/output pin for DHT11 (D2)

const unsigned long interval = 1000;  // Measurement interval in milliseconds
int val[100];
int max_v = 0;
double VmaxD = 0;
double VeffD = 0;
double Veff = 0;
double sensorValue1 = 0;

// ZMPT101B sensor output connected to analog pin A0
// and the voltage source frequency is 50 Hz.
ZMPT101B voltageSensor(voltagePin, 50.0);
DHT dht(dhtPin, DHTTYPE);

void setup() {
  Serial.begin(115200);
  // Connect to Wi-Fi
  WiFi.begin(ssid, password);
  while (WiFi.status() != WL_CONNECTED) {
    delay(1000);
    Serial.println("Connecting to WiFi...");
  }
  Serial.println("Connected to WiFi");

  // Connect to MQTT broker
  // mqttClient.setServer(mqtt_server, 1883);

  // Initialize DHT sensor
  dht.begin();
}

void loop() {
  // read the voltage and then print via Serial.
  for ( int i = 0; i < 100; i++ ) {
    sensorValue1 = analogRead(voltagePin);
    if (analogRead(voltagePin) > 2250) {
      val[i] = sensorValue1;
    }
    else {
      val[i] = 0;
    }
    delay(1);
  }

  max_v = 0;

  for ( int i = 0; i < 100; i++ )
  {
    if ( val[i] > max_v )
    {
      max_v = val[i];
    }
    val[i] = 0;
  }
  if (max_v != 0) {


    VmaxD = max_v;
    VeffD = VmaxD / sqrt(2);
    Veff = (((VeffD - 420.76) / -405.24) * -10.5) + 188.2;
  }
  else {
    Veff = 0;
  }
  // Perform numerical integration of voltage
  Serial.print("Voltage: ");
  Serial.println(Veff);
  VmaxD = 0;

  // Read current
  float current = analogRead(currentPin) * (3.3 / 4095.0);
  Serial.print("Current: ");
  Serial.println(current);

  
  // Read temperature and humidity
  float temperature = dht.readTemperature();
  float humidity = dht.readHumidity();
  Serial.print("Temperature: ");
  Serial.println(temperature);
  Serial.print("Humidity: ");
  Serial.println(humidity);

  // Publish data to MQTT topic
  // String voltageStr = String(voltage);
  // String currentStr = String(current);
  // String temperatureStr = String(temperature);
  // String humidityStr = String(humidity);

  // mqttClient.publish((String(mqtt_topic) + "/voltage").c_str(), voltageStr.c_str());
  // mqttClient.publish((String(mqtt_topic) + "/current").c_str(), currentStr.c_str());
  // mqttClient.publish((String(mqtt_topic) + "/temperature").c_str(), temperatureStr.c_str());
  // mqttClient.publish((String(mqtt_topic) + "/humidity").c_str(), humidityStr.c_str());

  Serial.print("-----------\n");

  delay(2000);
}
