library ieee;
use ieee.std_logic_1164.all; 
use ieee.numeric_std.all;

entity q3 is
	port (
		binary: in std_logic_vector(7 downto 0);
		bcd: out std_logic_vector(0 to 11)
	);
end q3;

architecture behaviour of q3 is
begin
	process(binary)
	variable int_val : integer := 0;
	variable r : integer := -1;
	variable i : integer := 8;
	variable result : std_logic_vector(0 to 11) := "000000000000";
	begin
		int_val := to_integer(unsigned(binary));
		while (int_val > 0) loop
			r := int_val mod 10;
			int_val := int_val / 10;
			result(i to i+3) := std_logic_vector(to_unsigned(r,4));
			i := i - 4;
		end loop;
		bcd <= result;
	end process;
end behaviour;
