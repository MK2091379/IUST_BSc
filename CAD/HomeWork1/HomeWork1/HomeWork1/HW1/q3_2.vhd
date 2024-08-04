----------------------------------------------------------------------------------
-- Company: 
-- Engineer: 
-- 
-- Create Date:    21:20:37 11/24/2022 
-- Design Name: 
-- Module Name:    q3_2 - Behavioral 
-- Project Name: 
-- Target Devices: 
-- Tool versions: 
-- Description: 
--
-- Dependencies: 
--
-- Revision: 
-- Revision 0.01 - File Created
-- Additional Comments: 
--
----------------------------------------------------------------------------------
library IEEE;
use IEEE.STD_LOGIC_1164.ALL;

-- Uncomment the following library declaration if using
-- arithmetic functions with Signed or Unsigned values
--use IEEE.NUMERIC_STD.ALL;

-- Uncomment the following library declaration if instantiating
-- any Xilinx primitives in this code.
--library UNISIM;
--use UNISIM.VComponents.all;

entity q3_2 is
	
    Port ( input : in  STD_LOGIC_VECTOR(3 downto 0);
           reminder : out  STD_LOGIC_VECTOR(3 downto 0)
			);
end q3_2;

architecture Behavioral of q3_2 is
	signal temp: std_logic_vector(3 downto 0);
begin

	temp <= "0000" when (input = "0000" or input = "0101" or input = "1010" or input = "1111")
			else "0001" when (input = "0001" or input = "0110" or input = "1011")
			else "0010" when (input = "0010" or input = "0111" or input = "1100")
			else "0011" when (input = "0011" or input = "1000" or input = "1101" )
			else "0100" when (input = "0100" or input = "1001" or input = "1110" );
			
	reminder <= temp;
end Behavioral;

