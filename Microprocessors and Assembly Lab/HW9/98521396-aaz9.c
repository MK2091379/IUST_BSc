
#include <mega32.h>

// Alphanumeric LCD functions
#include <alcd.h>

// Standard Input/Output functions
#include <stdio.h>

// Declare your global variables here

void usart_send_string(char *str);
unsigned char i;
void main(void)
{
unsigned char a, counter=0;

// USART initialization
// Communication Parameters: 8 Data, 1 Stop, No Parity
// USART Receiver: On
// USART Transmitter: On
// USART Mode: Asynchronous
// USART Baud Rate: 9600
UCSRA=0x00;
UCSRB=0x18;
UCSRC=0x86;
UBRRH=0x00;
UBRRL=0x33;

// Alphanumeric LCD initialization
// Connections are specified in the
// Project|Configure|C Compiler|Libraries|Alphanumeric LCD menu:
// RS - PORTC Bit 0
// RD - PORTC Bit 1
// EN - PORTC Bit 2
// D4 - PORTC Bit 4
// D5 - PORTC Bit 5
// D6 - PORTC Bit 6
// D7 - PORTC Bit 7
// Characters/line: 16

lcd_init(16);

while (1)
      {
        a = getchar();
        lcd_putchar(a);
        putchar(a);
        if(a == 'C')      
        {
            lcd_clear();  
            putchar(0x0D);
            putchar(0x0A); 
        }  
        else if(a == 'c')
        {
            for(counter =0; counter < 24; counter++)
            {          
                putchar(0x0D);   
                putchar(0x0A);
            }
        }
        else if(a == 'N')
        {       
            putchar(0x0D); 
            putchar(0x0A); 
            usart_send_string("AMIRHOSSEIN SAMAVAT");
            putchar(0x0D); 
            putchar(0x0A); 
            
        }
        else if(a == 'M')
        {
            
            putchar(0x0D);   
            putchar(0x0A);
            lcd_clear();
            lcd_gotoxy(5,0);
            lcd_puts("AMIRHOSSEIN");
            lcd_gotoxy(0,1);
            lcd_puts("SAMAVAT");          
        }
          
      }        
}

void usart_send_string(char *str)
{
    for(i=0;str[i];i++)
    putchar(str[i]);
}
