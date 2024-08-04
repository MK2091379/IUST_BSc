library IEEE;
use IEEE.STD_LOGIC_1164.ALL;

-- Uncomment the following library declaration if using
-- arithmetic functions with Signed or Unsigned values
--use IEEE.NUMERIC_STD.ALL;

-- Uncomment the following library declaration if instantiating
-- any Xilinx primitives in this code.
--library UNISIM;
--use UNISIM.VComponents.all;

entity q1 is
	PORT( x : in STD_LOGIC;
			y : in STD_LOGIC;
			z : out STD_LOGIC);
end q1;

architecture Behavioral of q1 is
begin
	
	process(x,y)
	begin
		z <= '0';
		if x = '1' then
			z <= '1';
		elsif x = '0' then
			if y = '0' then
				z <= '1';
			elsif y = '1' then
				z <= '0';
			end if;
		end if;
	end process;
end Behavioral;
