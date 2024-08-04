----------------------------------------------------------------------------------
-- Company: 
-- Engineer: 
-- 
-- Create Date:    19:40:32 11/24/2022 
-- Design Name: 
-- Module Name:    demultiplexer - Behavioral 
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

entity demultiplexer is
    Port ( a : in  STD_LOGIC;
           sel : in  STD_LOGIC_VECTOR(1 downto 0);
           out1 : out  STD_LOGIC;
           out2 : out  STD_LOGIC;
           out3 : out  STD_LOGIC;
           out4 : out  STD_LOGIC);
end demultiplexer;

architecture Behavioral of demultiplexer is
begin

		out1 <= '1' when ( sel = "00" ) else '0';
		out2 <= '1' when ( sel = "01" ) else '0';
		out3 <= '1' when ( sel = "10" ) else '0';
		out4 <= '1' when ( sel = "11" ) else '0';
		
end Behavioral;

