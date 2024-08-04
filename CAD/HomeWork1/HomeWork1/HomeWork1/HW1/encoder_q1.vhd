----------------------------------------------------------------------------------
-- Company: 
-- Engineer: 
-- 
-- Create Date:    19:07:10 11/24/2022 
-- Design Name: 
-- Module Name:    encoder_q1 - Behavioral 
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

entity encoder_q1 is
    Port ( I3 : in  STD_LOGIC;
           I2 : in  STD_LOGIC;
           I1 : in  STD_LOGIC;
           I0 : in  STD_LOGIC;
           O1 : out  STD_LOGIC;
           O0 : out  STD_LOGIC;
           V : out  STD_LOGIC);
end encoder_q1;

architecture Behavioral of encoder_q1 is
begin
process(I3,I2,I1,I0)
begin
	V <= I0 OR I1 OR I2 OR I3;
	O0 <= (I1 AND not I2) OR I3 ;  
	O1 <= I2 OR I3;               
end process;


end Behavioral;

