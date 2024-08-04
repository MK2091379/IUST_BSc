library IEEE;
use IEEE.STD_LOGIC_1164.ALL;
use IEEE.NUMERIC_STD.ALL;

entity q2 is
	port ( op1 : in std_logic_vector(31 downto 0);
			op2 : in std_logic_vector(31 downto 0);
			mul : out std_logic_vector(31 downto 0)
	);
end q2;

architecture Behavioral of q2 is
begin
	process(op1, op2)
		variable sign_bit : std_logic;
		variable exponent : std_logic_vector(7 downto 0);
		variable fraction : std_logic_vector(22 downto 0):= (others => '0');
		variable extended_bit : std_logic_vector(22 downto 0);
		variable mul_i : std_logic_vector(22 downto 0);
	begin
		sign_bit := op1(31) xor op2(31);
		exponent := std_logic_vector(unsigned(op1(30 downto 23)) + unsigned(op2(30 downto 23)));
		for i in 0 to 22 loop
			extended_bit := (others => op2(i));
			mul_i := extended_bit and op1(22 downto 0);
			mul_i := std_logic_vector(unsigned(mul_i) sll i);
			fraction := std_logic_vector(unsigned(fraction) + unsigned(mul_i));
		end loop;
		mul(31) <= sign_bit;
		mul(30 downto 23) <= exponent;
		mul(22 downto 0) <= fraction;
	end process;
end Behavioral;
