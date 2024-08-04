library ieee;
use ieee.std_logic_1164.all; 
use ieee.numeric_std.all;

entity q2 is
	generic (
		n : integer := 16;
		m: integer := 5
	);
	port (
		input: in std_logic_vector(0 to n-1);
		output1: out std_logic_vector(m-1 downto 0);
		output2: out std_logic_vector(m-1 downto 0)
	);
end q2;

architecture q2 of q2 is
begin
	process(input)
	variable pos1: integer := -1;
	variable pos2: integer := -1;
	begin
		for i in 0 to n-1 loop
			if (input(i) = '1') then
				if (pos1 = -1) then
					pos1 := i + 1;
				end if;
				pos2 := i + 1;
			end if;
		end loop;
		output1 <= std_logic_vector(to_unsigned(pos1,m));
		output2 <= std_logic_vector(to_unsigned(pos2,m));
	end process;
end q2;
