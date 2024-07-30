//amirhossein samavat 98521252
/*******************************************************
This program was created by the
CodeWizardAVR V3.12 Advanced
Automatic Program Generator
� Copyright 1998-2014 Pavel Haiduc, HP InfoTech s.r.l.
http://www.hpinfotech.com

Project : 
Version : 
Date    : 3/14/2022
Author  :  amirhossein samavat 
Company : 
Comments: 


Chip type               : ATmega32
Program type            : Application
AVR Core Clock frequency: 8.000000 MHz
Memory model            : Small
External RAM size       : 0
Data Stack size         : 512
*******************************************************/

#include <mega32.h>
#include <delay.h>



unsigned char TensHour = 2;
unsigned char OnesHour = 3; 
unsigned char TensMin = 5;
unsigned char OnesMin = 8;
unsigned char TensSec = 0;
unsigned char OnesSec = 0;
unsigned char DP = 0x80;



unsigned char a = 1;
interrupt [TIM1_COMPA] void Timers_Compare(void)
{
a = a << 1;
if(a==0) a= 1;

  OnesSec=OnesSec+1; 
  if(OnesSec % 2 != 0)
  {
        DP = 0x00;
  }
  if(OnesSec %2 ==0)
   {
    DP = 0x80;
   } 
 
  if(OnesSec==10)
   {
        OnesSec=0;
        TensSec=TensSec+1;
  } 
  if(TensSec==6)
  {
     TensSec=0;
     OnesMin=OnesMin+1;
  }
   if(OnesMin==10)
   {
   
      OnesMin=0;
      TensMin=TensMin+1;
   } 
   if( TensMin==6)
   {
        TensMin=0;
        OnesHour=OnesHour+1;
   } 
   if(OnesHour==10)
   {
       OnesHour=0;
       TensHour=TensHour+1;
   } 
   if(TensHour==2 && OnesHour==4)
   {   
        OnesHour=0;
        TensHour=0;
   }
  

}

int ParseToHex(char x){
switch (x) 
   {    
        case 1: return 0x06; 
               break; 
       case 2: return 0x5b; 
                break; 
       case 3: return 0x4F; 
               break;    
       case 4:return 0x66;
                break;
       case 5: return 0x6D; 
               break; 
       case 6: return 0x7D; 
                break; 
       case 7: return 0x07; 
               break; 
        case 8: return 0x7F; 
               break; 
       case 9: return 0x6F; 
                break; 
       default:return 0x3F; 
                break;   
   } 
}

void main(void)
{
DDRA=(0<<DDA7) | (0<<DDA6) | (0<<DDA5) | (0<<DDA4) | (0<<DDA3) | (0<<DDA2) | (0<<DDA1) | (0<<DDA0);
 
PORTA=(0<<PORTA7) | (0<<PORTA6) | (0<<PORTA5) | (0<<PORTA4) | (0<<PORTA3) | (0<<PORTA2) | (0<<PORTA1) | (0<<PORTA0);

DDRB=(1<<DDB7) | (1<<DDB6) | (1<<DDB5) | (1<<DDB4) | (1<<DDB3) | (1<<DDB2) | (1<<DDB1) | (1<<DDB0);
 
PORTB=(0<<PORTB7) | (0<<PORTB6) | (0<<PORTB5) | (0<<PORTB4) | (0<<PORTB3) | (0<<PORTB2) | (0<<PORTB1) | (0<<PORTB0);

DDRC=(1<<DDC7) | (1<<DDC6) | (1<<DDC5) | (1<<DDC4) | (1<<DDC3) | (1<<DDC2) | (1<<DDC1) | (1<<DDC0);

PORTC=(0<<PORTC7) | (0<<PORTC6) | (0<<PORTC5) | (0<<PORTC4) | (0<<PORTC3) | (0<<PORTC2) | (0<<PORTC1) | (0<<PORTC0);

DDRD=(1<<DDD7) | (1<<DDD6) | (1<<DDD5) | (1<<DDD4) | (1<<DDD3) | (1<<DDD2) | (1<<DDD1) | (1<<DDD0);

PORTD=(0<<PORTD7) | (0<<PORTD6) | (0<<PORTD5) | (0<<PORTD4) | (0<<PORTD3) | (0<<PORTD2) | (0<<PORTD1) | (0<<PORTD0);

TCCR0=(0<<WGM00) | (0<<COM01) | (0<<COM00) | (0<<WGM01) | (0<<CS02) | (0<<CS01) | (0<<CS00);
TCNT0=0x00;
OCR0=0x00;

TCCR1A=(0<<COM1A1) | (0<<COM1A0) | (0<<COM1B1) | (0<<COM1B0) | (0<<WGM11) | (0<<WGM10);
TCCR1B=(0<<ICNC1) | (0<<ICES1) | (0<<WGM13) | (1<<WGM12) | (1<<CS12) | (0<<CS11) | (0<<CS10);
TCNT1H=0x00;
TCNT1L=0x00;
ICR1H=0x00;
ICR1L=0x00;
OCR1AH=0x7A;
OCR1AL=0x12;
OCR1BH=0x00;
OCR1BL=0x00;

ASSR=0<<AS2;
TCCR2=(0<<PWM2) | (0<<COM21) | (0<<COM20) | (0<<CTC2) | (0<<CS22) | (0<<CS21) | (0<<CS20);
TCNT2=0x00;
OCR2=0x00;


TIMSK=(0<<OCIE2) | (0<<TOIE2) | (0<<TICIE1) | (1<<OCIE1A) | (0<<OCIE1B) | (0<<TOIE1) | (0<<OCIE0) | (0<<TOIE0);

MCUCR=(0<<ISC11) | (0<<ISC10) | (0<<ISC01) | (0<<ISC00);
MCUCSR=(0<<ISC2);


UCSRB=(0<<RXCIE) | (0<<TXCIE) | (0<<UDRIE) | (0<<RXEN) | (0<<TXEN) | (0<<UCSZ2) | (0<<RXB8) | (0<<TXB8);


ACSR=(1<<ACD) | (0<<ACBG) | (0<<ACO) | (0<<ACI) | (0<<ACIE) | (0<<ACIC) | (0<<ACIS1) | (0<<ACIS0);
SFIOR=(0<<ACME);


ADCSRA=(0<<ADEN) | (0<<ADSC) | (0<<ADATE) | (0<<ADIF) | (0<<ADIE) | (0<<ADPS2) | (0<<ADPS1) | (0<<ADPS0);


SPCR=(0<<SPIE) | (0<<SPE) | (0<<DORD) | (0<<MSTR) | (0<<CPOL) | (0<<CPHA) | (0<<SPR1) | (0<<SPR0);


TWCR=(0<<TWEA) | (0<<TWSTA) | (0<<TWSTO) | (0<<TWEN) | (0<<TWIE);

#asm("sei")

while (1)
      { 
      PORTB = a;
      // Place your code here     
      PORTD = 0b11111110;
      PORTC = ParseToHex(TensHour);
      delay_ms(7);
      PORTD = 0b11111101;  
      PORTC = ParseToHex(OnesHour) | DP;
      delay_ms(7);
      PORTD = 0b11111011;
      PORTC = ParseToHex(TensMin);
      delay_ms(7);
      PORTD = 0b11110111;
      PORTC = ParseToHex(OnesMin) | DP ;
      delay_ms(7);
      PORTD = 0b11101111;
      PORTC = ParseToHex(TensSec);
      delay_ms(7);
      PORTD = 0b11011111;
      PORTC = ParseToHex(OnesSec) | DP ;
      delay_ms(7);
      }
}