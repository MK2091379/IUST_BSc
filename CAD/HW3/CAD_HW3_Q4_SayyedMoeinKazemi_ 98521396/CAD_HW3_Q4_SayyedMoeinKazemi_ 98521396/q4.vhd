library ieee;
use ieee.std_logic_1164.all; 
use ieee.numeric_std.all;

entity q4 is
	port (
	unary : in std_logic_vector(15 downto 0) := "0000000000000000";
	binary : out std_logic_vector(3 downto 0) := "0000"
	);
end q4;
	
architecture behaviour of q4 is
begin
	process (unary)
	variable sum : integer := 0;
	variable i : integer := 0;
	begin
		while (unary(i) = '1' and i < 16) loop
			sum := sum + 1;
			i := i + 1;
		end loop;
	binary <= std_logic_vector(to_unsigned(sum,4));
	end process;
end behaviour;
