/*****************************************************
mohammad amin geramimehr:98521441
*****************************************************/

#include <mega32.h>
#include <alcd.h>
#include <delay.h>

#define KEYPAD_R1 PORTD.0
#define KEYPAD_R2 PORTD.1
#define KEYPAD_R3 PORTD.2
#define KEYPAD_R4 PORTD.3
#define KEYPAD_C1 PIND.4
#define KEYPAD_C2 PIND.5
#define KEYPAD_C3 PIND.6
#define KEYPAD_C4 PIND.7

#define KEYPAD_NUM0 0
#define KEYPAD_NUM1 1
#define KEYPAD_NUM2 2
#define KEYPAD_NUM3 3
#define KEYPAD_NUM4 4
#define KEYPAD_NUM5 5
#define KEYPAD_NUM6 6
#define KEYPAD_NUM7 7
#define KEYPAD_NUM8 8
#define KEYPAD_NUM9 9
#define KEYPAD_DIV  10
#define KEYPAD_MUL  11
#define KEYPAD_PLS  12
#define KEYPAD_MNS  13
#define KEYPAD_EQU  14
#define KEYPAD_ON   15

unsigned char keypad_scan();

void main(void)
{
    unsigned char key_res; 
    char number1 = 0, number2 = 0;
    char result;
    unsigned char error_flag = 0;
    unsigned char current_number = 1;
    unsigned char op = 255;
    DDRC=0xFF;
    DDRD=0x0F;
    PORTC=0x00;

    lcd_init(16);
    lcd_clear();
    lcd_gotoxy(1,0);
    lcd_puts("KEYPAD AND LCD");
    lcd_gotoxy(5,1);
    lcd_puts("PROJECT");
    delay_ms(2000);
    lcd_clear();

    while (1)
    {
        key_res = keypad_scan();
        if(key_res != 255)
        { 
            while(keypad_scan() != 255);
            delay_ms(20);
            if (key_res == KEYPAD_DIV)
            {
                lcd_putchar('%');
                op = KEYPAD_DIV;
                current_number = 2;
            }
            else if (key_res == KEYPAD_MUL)
            {
                lcd_putchar('*');
                op = KEYPAD_MUL;
                current_number = 2;
            } 
            else if (key_res == KEYPAD_MNS)
            {
                lcd_putchar('-');
                op = KEYPAD_MNS;
                current_number = 2;
            }
            else if (key_res == KEYPAD_PLS)
            {
                lcd_putchar('+');
                op = KEYPAD_PLS;
                current_number = 2;
            }
            else if (key_res == KEYPAD_EQU)
            {
                lcd_putchar('=');
                delay_ms(1000);
                lcd_clear();
                lcd_gotoxy(0,0);
                if (op != 255)
                {
                    if (op == KEYPAD_PLS)
                        result = number1 + number2;
                    else if (op == KEYPAD_MNS)
                    {                           
                        if (number1 >= number2)
                            result = number1 - number2;
                        else
                        {                              
                            lcd_putchar('-');
                            result = number2 - number1;
                        }
                    }
                    else if (op == KEYPAD_MUL)
                        result = number1 * number2;
                    else if (op == KEYPAD_DIV)
                    {
                        if (number2 == 0)
                            error_flag = 1;
                        else
                            result = number1 / number2;
                    }    
                }
                else
                    result = number1;
                if (error_flag == 0)
                {
                    if (result >= 100)
                        lcd_putchar((result / 100) + '0');
                    if (result >= 10)
                        lcd_putchar(((result % 100) / 10) + '0');
                    lcd_putchar((result % 10) + '0');
                }
                else
                    lcd_puts("Error");
                
                delay_ms(3000);
                number1 = 0;
                number2 = 0;
                current_number = 1;
                op = 255;
                error_flag = 0;
                lcd_gotoxy(0,0);
            }
            else if (key_res == KEYPAD_ON)
            {
                number1 = 0;
                number2 = 0;
                current_number = 1;
                op = 255;
                lcd_clear();
                error_flag = 0;
                lcd_gotoxy(0,0);
            }                               
            else
            {
                lcd_putchar(key_res + 48);
                if (current_number == 1)
                    number1 = number1 * 10 + key_res;
                else
                    number2 = number2 * 10 + key_res;
            }    
        }
    }
}


unsigned char keypad_scan()
{
unsigned char result=255;
////////////////////////  ROW1 ////////////////////////
KEYPAD_R1 = 1; KEYPAD_R2 = 0;  KEYPAD_R3 = 0;  KEYPAD_R4 = 0; //set Row1 for Keypad
delay_ms(5);
if (KEYPAD_C1)
result = KEYPAD_NUM7;
else if (KEYPAD_C2)
result = KEYPAD_NUM8;
else if (KEYPAD_C3)
result = KEYPAD_NUM9;
else if (KEYPAD_C4)
result = KEYPAD_DIV;

////////////////////////  ROW2 ////////////////////////
KEYPAD_R1 = 0; KEYPAD_R2 = 1;  KEYPAD_R3 = 0;  KEYPAD_R4 = 0; //set Row2 for Keypad
delay_ms(5);
if (KEYPAD_C1)
result = KEYPAD_NUM4;
else if (KEYPAD_C2)
result = KEYPAD_NUM5;
else if (KEYPAD_C3)
result = KEYPAD_NUM6;
else if (KEYPAD_C4)
result = KEYPAD_MUL;

////////////////////////  ROW3 ////////////////////////
KEYPAD_R1 = 0; KEYPAD_R2 = 0;  KEYPAD_R3 = 1;  KEYPAD_R4 = 0; //set Row3 for Keypad
delay_ms(5);
if (KEYPAD_C1)
result = KEYPAD_NUM1;
else if (KEYPAD_C2)
result = KEYPAD_NUM2;
else if (KEYPAD_C3)
result = KEYPAD_NUM3;
else if (KEYPAD_C4)
result = KEYPAD_MNS;

////////////////////////  ROW4 ////////////////////////
KEYPAD_R1 = 0; KEYPAD_R2 = 0;  KEYPAD_R3 = 0;  KEYPAD_R4 = 1; //set Row4 for Keypad
delay_ms(5);
if (KEYPAD_C1)
result = KEYPAD_ON;
else if (KEYPAD_C2)
result = KEYPAD_NUM0;
else if (KEYPAD_C3)
result = KEYPAD_EQU;
else if (KEYPAD_C4)
result = KEYPAD_PLS;

return result;
} 
