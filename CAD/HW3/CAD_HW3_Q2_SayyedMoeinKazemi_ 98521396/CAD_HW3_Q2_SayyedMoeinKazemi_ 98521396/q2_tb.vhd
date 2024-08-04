library ieee;
use ieee.std_logic_1164.all; 
use ieee.numeric_std.all;

entity q2_tb is
end q2_tb;

architecture q2_tb of q2_tb is
signal input : std_logic_vector(0 to 15) := "0010001010111000";
signal output1 : std_logic_vector(4 downto 0) := "00000";
signal output2 : std_logic_vector(4 downto 0) := "00000";
begin
	device: entity work.q2
	port map (
	input => input,
	output1 => output1,
	output2 => output2
	);
end q2_tb;
