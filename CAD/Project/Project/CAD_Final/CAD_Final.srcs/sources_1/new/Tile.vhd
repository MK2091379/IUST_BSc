----------------------------------------------------------------------------------
-- Company: 
-- Engineer: 
-- 
-- Create Date: 01/25/2023 11:09:08 AM
-- Design Name: 
-- Module Name: Tile - Behavioral
-- Project Name: 
-- Target Devices: 
-- Tool Versions: 
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
use IEEE.NUMERIC_STD.ALL;
use work.pack.all ;
-- Uncomment the following library declaration if instantiating
-- any Xilinx leaf cells in this code.
--library UNISIM;
--use UNISIM.VComponents.all;

entity TileRow is
  Port (
    windowROw : in WindowRow_type ;
    Filter : in filter_type ;
    FMRow : out FMRow_type 
   );
end TileRow ;



architecture Behavioral of TileRow  is
    component  PE is
         port (
        window : in window_type;
        filter : in filter_type ;
        convRes : out real
    );
    end component ;
    signal res : FMRow_type ;
begin
    genU : for i in 0 to 125 generate 
            U: PE port map (window => windowROw(i) , 
                            Filter => Filter , 
                            convres => res(i));
           end generate ;
    FMRow <= res;
    
end Behavioral;
