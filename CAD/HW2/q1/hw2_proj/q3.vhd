library IEEE;
use IEEE.STD_LOGIC_1164.ALL;

-- Uncomment the following library declaration if using
-- arithmetic functions with Signed or Unsigned values
--use IEEE.NUMERIC_STD.ALL;

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
	-- 4 * array (256 *32)

begin


end Behavioral;
