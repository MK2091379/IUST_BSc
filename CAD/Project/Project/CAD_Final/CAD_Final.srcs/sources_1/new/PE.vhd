library IEEE;
use IEEE.STD_LOGIC_1164.ALL;

-- Uncomment the following library declaration if using
-- arithmetic functions with Signed or Unsigned values
use IEEE.NUMERIC_STD.ALL;
use work.pack.all;
-- Uncomment the following library declaration if instantiating
-- any Xilinx leaf cells in this code.
--library UNISIM;
--use UNISIM.VComponents.all;

entity PE is
    port (
        window : in window_type;
        filter : in filter_type ;
        convRes : out real
    );
end PE;
architecture behav of PE is
    signal ZZ,ZO,ZT,OZ,OO,OT,TZ,TOO,TT : real ;
    signal sum1,sum2,sum3,sum4,sum5,sum6,sum7 : real;
begin
    ZZ <= real(window (0,0)) * filter (0,0);
    ZO <= real(window (0,1)) * filter (0,1);
    ZT <= real(window (0,2)) * filter (0,2);
    OZ <= real(window (1,0)) * filter (1,0);
    OO <= real(window (1,1)) * filter (1,1);
    OT <= real(window (1,2)) * filter (1,2);
    TZ <= real(window (2,0)) * filter (2,0);
    TOO <= real(window (2,1)) * filter (2,1);
    TT <= real(window (2,2)) * filter (2,2);
    sum1 <= ZZ + ZO ;
    Sum2 <= ZT + OZ;
    sum3 <= OO + OT;
    sum4 <= TZ + TOO;
    sum5 <= sum1 +sum2;
    sum6 <= sum3 + sum4;
    sum7 <= sum5 + sum6;
    convRes <= (sum7 + TT)/9;
end behav;