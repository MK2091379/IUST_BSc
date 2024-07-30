





/*******************************************************
This program was created by the
CodeWizardAVR V3.12 Advanced
Automatic Program Generator
� Copyright 1998-2014 Pavel Haiduc, HP InfoTech s.r.l.
http://www.hpinfotech.com

Project : 
Version : 
Date    : 4/1/2022
Author  : 
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

// Declare your global variables here

// Timer1 output compare A interrupt service routine
interrupt [TIM1_COMPA] void timer1_compa_isr(void)
{
// Place your code here

}




const unsigned char image_code[79]=
{
    0xFF,    //    0001        # # # # # # # # 
    0xFF,    //    0002        # # # # # # # # 
    0xFF,    //    0003        # # # # # # # # 
    0xFF,    //    0004        # # # # # # # # 
    0xFF,    //    0005        # # # # # # # # 
    0xFF,    //    0006        # # # # # # # # 
    0xFF,    //    0007        # # # # # # # # 
    0xFF,    //    0008        # # # # # # # # 
    0xFF,    //    0009        # # # # # # # # 
    0xFF,    //    000A        # # # # # # # # 
    0xFF,    //    000B        # # # # # # # # 
    0xFF,    //    000C        # # # # # # # # 
    0xFF,    //    000D        # # # # # # # # 
    0xFF,    //    000E        # # # # # # # # 
    0xFF,    //    000F        # # # # # # # # 
    0xFF,    //    0010        # # # # # # # # 
    0x07,    //    0011        . . . . . # # # 
    0x03,    //    0012        . . . . . . # # 
    0xD9,    //    0013        # # . # # . . # 
    0xDC,    //    0014        # # . # # # . . 
    0xD9,    //    0015        # # . # # . . # 
    0x03,    //    0016        . . . . . . # # 
    0x07,    //    0017        . . . . . # # # 
    0xFF,    //    0018        # # # # # # # # 
    0x00,    //    0019        . . . . . . . . 
    0x00,    //    001A        . . . . . . . . 
    0x6E,    //    001B        . # # . # # # . 
    0x6E,    //    001C        . # # . # # # . 
    0x6E,    //    001D        . # # . # # # . 
    0x6E,    //    001E        . # # . # # # . 
    0x11,    //    001F        . . . # . . . # 
    0xFF,    //    0020        # # # # # # # # 
    0xC3,    //    0021        # # . . . . # # 
    0x81,    //    0022        # . . . . . . # 
    0x3C,    //    0023        . . # # # # . . 
    0x7E,    //    0024        . # # # # # # . 
    0x7E,    //    0025        . # # # # # # . 
    0x7E,    //    0026        . # # # # # # . 
    0xBD,    //    0027        # . # # # # . # 
    0xFF,    //    0028        # # # # # # # # 
    0x00,    //    0029        . . . . . . . . 
    0x00,    //    002A        . . . . . . . . 
    0x7E,    //    002B        . # # # # # # . 
    0x7E,    //    002C        . # # # # # # . 
    0x7E,    //    002D        . # # # # # # . 
    0xBD,    //    002E        # . # # # # . # 
    0xC3,    //    002F        # # . . . . # # 
    0xFF,    //    0030        # # # # # # # # 
    0x00,    //    0031        . . . . . . . . 
    0x00,    //    0032        . . . . . . . . 
    0x76,    //    0033        . # # # . # # . 
    0x76,    //    0034        . # # # . # # . 
    0x76,    //    0035        . # # # . # # . 
    0x76,    //    0036        . # # # . # # . 
    0x7E,    //    0037        . # # # # # # . 
    0xFF,    //    0038        # # # # # # # # 
    0x00,    //    0039        . . . . . . . . 
    0x00,    //    003A        . . . . . . . . 
    0xF6,    //    003B        # # # # . # # . 
    0xF6,    //    003C        # # # # . # # . 
    0xF6,    //    003D        # # # # . # # . 
    0xF6,    //    003E        # # # # . # # . 
    0xFE,    //    003F        # # # # # # # . 
    0xFF,    //    0040        # # # # # # # # 
    0xFF,    //    0041        # # # # # # # # 
    0xFF,    //    0042        # # # # # # # # 
    0xFF,    //    0043        # # # # # # # # 
    0xFF,    //    0044        # # # # # # # # 
    0xFF,    //    0045        # # # # # # # # 
    0xFF,    //    0046        # # # # # # # # 
    0xFF,    //    0047        # # # # # # # # 
    0xFF,    //    0048        # # # # # # # # 
    0xFF,    //    0049        # # # # # # # # 
    0xFF,    //    004A        # # # # # # # # 
    0xFF,    //    004B        # # # # # # # # 
    0xFF,    //    004C        # # # # # # # # 
    0xFF,    //    004D        # # # # # # # # 
    0xFF,    //    004E        # # # # # # # # 
    0xFF     //    004F        # # # # # # # # 
};




void main(void)
{
// Declare your local variables here
unsigned char Col,Scan,Refresh,Index,S;

// Input/Output Ports initialization
// Port A initialization
// Function: Bit7=In Bit6=In Bit5=In Bit4=In Bit3=In Bit2=In Bit1=In Bit0=In 
DDRA=(0<<DDA7) | (0<<DDA6) | (0<<DDA5) | (0<<DDA4) | (0<<DDA3) | (0<<DDA2) | (0<<DDA1) | (0<<DDA0);
// State: Bit7=T Bit6=T Bit5=T Bit4=T Bit3=T Bit2=T Bit1=T Bit0=T 
PORTA=(0<<PORTA7) | (0<<PORTA6) | (0<<PORTA5) | (0<<PORTA4) | (0<<PORTA3) | (0<<PORTA2) | (0<<PORTA1) | (0<<PORTA0);

// Port B initialization
// Function: Bit7=In Bit6=In Bit5=In Bit4=In Bit3=In Bit2=In Bit1=In Bit0=In 
DDRB=(0<<DDB7) | (0<<DDB6) | (0<<DDB5) | (0<<DDB4) | (0<<DDB3) | (0<<DDB2) | (0<<DDB1) | (0<<DDB0);
// State: Bit7=T Bit6=T Bit5=T Bit4=T Bit3=T Bit2=T Bit1=T Bit0=T 
PORTB=(0<<PORTB7) | (0<<PORTB6) | (0<<PORTB5) | (0<<PORTB4) | (0<<PORTB3) | (0<<PORTB2) | (0<<PORTB1) | (0<<PORTB0);

// Port C initialization
// Function: Bit7=Out Bit6=Out Bit5=Out Bit4=Out Bit3=Out Bit2=Out Bit1=Out Bit0=Out 
DDRC=(1<<DDC7) | (1<<DDC6) | (1<<DDC5) | (1<<DDC4) | (1<<DDC3) | (1<<DDC2) | (1<<DDC1) | (1<<DDC0);
// State: Bit7=0 Bit6=0 Bit5=0 Bit4=0 Bit3=0 Bit2=0 Bit1=0 Bit0=0 
PORTC=(0<<PORTC7) | (0<<PORTC6) | (0<<PORTC5) | (0<<PORTC4) | (0<<PORTC3) | (0<<PORTC2) | (0<<PORTC1) | (0<<PORTC0);

// Port D initialization
// Function: Bit7=In Bit6=In Bit5=In Bit4=In Bit3=In Bit2=In Bit1=In Bit0=In 
DDRD=(0<<DDD7) | (0<<DDD6) | (0<<DDD5) | (0<<DDD4) | (0<<DDD3) | (0<<DDD2) | (0<<DDD1) | (0<<DDD0);
// State: Bit7=T Bit6=T Bit5=T Bit4=T Bit3=T Bit2=T Bit1=T Bit0=T 
PORTD=(0<<PORTD7) | (0<<PORTD6) | (0<<PORTD5) | (0<<PORTD4) | (0<<PORTD3) | (0<<PORTD2) | (0<<PORTD1) | (0<<PORTD0);

// Timer/Counter 1 initialization
// Clock source: System Clock
// Clock value: 1000.000 kHz
// Mode: CTC top=OCR1A
// OC1A output: Disconnected
// OC1B output: Disconnected
// Noise Canceler: Off
// Input Capture on Falling Edge
// Timer Period: 16.385 ms
// Timer1 Overflow Interrupt: Off
// Input Capture Interrupt: Off
// Compare A Match Interrupt: On
// Compare B Match Interrupt: Off
TCCR1A=(0<<COM1A1) | (0<<COM1A0) | (0<<COM1B1) | (0<<COM1B0) | (0<<WGM11) | (0<<WGM10);
TCCR1B=(0<<ICNC1) | (0<<ICES1) | (0<<WGM13) | (1<<WGM12) | (0<<CS12) | (1<<CS11) | (0<<CS10);
TCNT1H=0x00;
TCNT1L=0x00;
ICR1H=0x00;
ICR1L=0x00;
OCR1AH=0x40;
OCR1AL=0x00;
OCR1BH=0x00;
OCR1BL=0x00;

// Timer(s)/Counter(s) Interrupt(s) initialization
TIMSK=(0<<OCIE2) | (0<<TOIE2) | (0<<TICIE1) | (1<<OCIE1A) | (0<<OCIE1B) | (0<<TOIE1) | (0<<OCIE0) | (0<<TOIE0);

// Global enable interrupts
#asm("sei")

while (1)
      {
      // Place your code here
        for(S=8;S<72;S++)
        {
          for(Refresh=0;Refresh<5;Refresh++)
          {
	          Scan=0b00000001;
	          for(Col=0;Col<8;Col++)
	          {   
		        Index=Col+S;  
		        PORTB=Scan;
		        PORTC=image_code[Index] ;
		        delay_ms(4);
		        PORTB=0x00;
		        PORTD=Scan;
		        PORTC=image_code[Index-8] ;
		        delay_ms(2);    

		        PORTD=0x00;
		        Scan=Scan<<1;
         	}   
          }
        }
      }
}
