library IEEE;
use IEEE.STD_LOGIC_1164.ALL;

use IEEE.NUMERIC_STD.ALL;

-- Uncomment the following library declaration if instantiating
-- any Xilinx primitives in this code.
--library UNISIM;
--use UNISIM.VComponents.all;

entity q3 is
	port ( addr : in std_logic_vector(31 downto 0);
			data : out std_logic_vector(31 downto 0);
			hit : out std_logic
	);
end q3;

architecture Behavioral of q3 is
	type table is array(255 downto 0) of std_logic_vector(54 downto 0);
	signal t1, t2, t3, t4 : table;
	signal row : integer;
	signal hit1, hit2, hit3 , hit4 : std_logic;
begin
	row <= to_integer(unsigned(addr(9 downto 2)));
	process(row)
	begin
	
	if addr(31 downto 10) = t1(row)(53 downto 32) then 
		hit1 <= t1(row)(54);
	else
		hit1 <= '0';
	end if;
	if addr(31 downto 10) = t2(row)(53 downto 32) then 
		hit2 <= t1(row)(54);
	else
		hit2 <= '0';
	end if;
	if addr(31 downto 10) = t3(row)(53 downto 32) then 
		hit3 <= t1(row)(54);
	else
		hit3 <= '0';
	end if;
	if addr(31 downto 10) = t4(row)(53 downto 32) then 
		hit4 <= t4(row)(54);
	else
		hit4 <= '0';
	end if;
	hit <= hit1 or hit2 or hit3 or hit4;
	
	if hit1 = '1' then
		data <= t1(row)(31 downto 0);
	elsif hit2 = '1' then
		data <= t2(row)(31 downto 0);
	elsif hit3 = '1' then
		data <= t3(row)(31 downto 0);
	elsif hit4 = '1' then
		data <= t4(row)(31 downto 0);
	else
		data <= (others => '0');
	end if;
	end process;
end Behavioral;
