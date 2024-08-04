/**********************************************************************/
/*   ____  ____                                                       */
/*  /   /\/   /                                                       */
/* /___/  \  /                                                        */
/* \   \   \/                                                       */
/*  \   \        Copyright (c) 2003-2009 Xilinx, Inc.                */
/*  /   /          All Right Reserved.                                 */
/* /---/   /\                                                         */
/* \   \  /  \                                                      */
/*  \___\/\___\                                                    */
/***********************************************************************/

/* This file is designed for use with ISim build 0x7708f090 */

#define XSI_HIDE_SYMBOL_SPEC true
#include "xsi.h"
#include <memory.h>
#ifdef __GNUC__
#include <stdlib.h>
#else
#include <malloc.h>
#define alloca _alloca
#endif
static const char *ng0 = "D:/CAD/HW1/HW1/stack_q4.vhd";



static void work_a_1752173841_3212880686_p_0(char *t0)
{
    char *t1;
    char *t2;
    unsigned char t3;
    char *t4;
    char *t5;
    char *t6;
    char *t7;
    unsigned char t8;
    unsigned char t9;
    unsigned char t10;
    unsigned char t11;
    int t12;
    unsigned char t13;
    char *t14;
    char *t15;
    int t16;
    unsigned int t17;
    unsigned int t18;
    unsigned int t19;
    int t20;

LAB0:    xsi_set_current_line(50, ng0);
    t1 = (t0 + 1992U);
    t2 = *((char **)t1);
    t3 = *((unsigned char *)t2);
    t1 = (t0 + 4152);
    t4 = (t1 + 56U);
    t5 = *((char **)t4);
    t6 = (t5 + 56U);
    t7 = *((char **)t6);
    *((unsigned char *)t7) = t3;
    xsi_driver_first_trans_fast_port(t1);
    xsi_set_current_line(51, ng0);
    t1 = (t0 + 2152U);
    t2 = *((char **)t1);
    t3 = *((unsigned char *)t2);
    t1 = (t0 + 4216);
    t4 = (t1 + 56U);
    t5 = *((char **)t4);
    t6 = (t5 + 56U);
    t7 = *((char **)t6);
    *((unsigned char *)t7) = t3;
    xsi_driver_first_trans_fast_port(t1);
    xsi_set_current_line(54, ng0);
    t1 = (t0 + 1352U);
    t2 = *((char **)t1);
    t3 = *((unsigned char *)t2);
    t1 = (t0 + 4280);
    t4 = (t1 + 56U);
    t5 = *((char **)t4);
    t6 = (t5 + 56U);
    t7 = *((char **)t6);
    *((unsigned char *)t7) = t3;
    xsi_driver_first_trans_fast(t1);
    xsi_set_current_line(56, ng0);
    t1 = (t0 + 1352U);
    t2 = *((char **)t1);
    t8 = *((unsigned char *)t2);
    t9 = (t8 == (unsigned char)2);
    if (t9 == 1)
        goto LAB5;

LAB6:    t3 = (unsigned char)0;

LAB7:    if (t3 != 0)
        goto LAB2;

LAB4:
LAB3:    xsi_set_current_line(72, ng0);
    t1 = (t0 + 1352U);
    t2 = *((char **)t1);
    t8 = *((unsigned char *)t2);
    t9 = (t8 == (unsigned char)3);
    if (t9 == 1)
        goto LAB23;

LAB24:    t3 = (unsigned char)0;

LAB25:    if (t3 != 0)
        goto LAB20;

LAB22:
LAB21:    xsi_set_current_line(88, ng0);
    t1 = (t0 + 2768U);
    t2 = *((char **)t1);
    t12 = *((int *)t2);
    t1 = (t0 + 4600);
    t4 = (t1 + 56U);
    t5 = *((char **)t4);
    t6 = (t5 + 56U);
    t7 = *((char **)t6);
    *((int *)t7) = t12;
    xsi_driver_first_trans_fast(t1);
    t1 = (t0 + 4072);
    *((int *)t1) = 1;

LAB1:    return;
LAB2:    xsi_set_current_line(57, ng0);
    t1 = (t0 + 2768U);
    t5 = *((char **)t1);
    t12 = *((int *)t5);
    t13 = (t12 == 255);
    if (t13 != 0)
        goto LAB8;

LAB10:    xsi_set_current_line(61, ng0);
    t1 = (t0 + 4344);
    t2 = (t1 + 56U);
    t4 = *((char **)t2);
    t5 = (t4 + 56U);
    t6 = *((char **)t5);
    *((unsigned char *)t6) = (unsigned char)2;
    xsi_driver_first_trans_fast(t1);
    xsi_set_current_line(62, ng0);
    t1 = (t0 + 4408);
    t2 = (t1 + 56U);
    t4 = *((char **)t2);
    t5 = (t4 + 56U);
    t6 = *((char **)t5);
    *((unsigned char *)t6) = (unsigned char)2;
    xsi_driver_first_trans_fast(t1);

LAB9:    xsi_set_current_line(64, ng0);
    t1 = (t0 + 2312U);
    t2 = *((char **)t1);
    t8 = *((unsigned char *)t2);
    t9 = (t8 == (unsigned char)3);
    if (t9 == 1)
        goto LAB14;

LAB15:    t3 = (unsigned char)0;

LAB16:    if (t3 != 0)
        goto LAB11;

LAB13:
LAB12:    xsi_set_current_line(67, ng0);
    t1 = (t0 + 1832U);
    t2 = *((char **)t1);
    t1 = (t0 + 2768U);
    t4 = *((char **)t1);
    t12 = *((int *)t4);
    t16 = (t12 - 0);
    t17 = (t16 * 1);
    xsi_vhdl_check_range_of_index(0, 15, 1, t12);
    t18 = (8U * t17);
    t19 = (0 + t18);
    t1 = (t2 + t19);
    t5 = (t0 + 4472);
    t6 = (t5 + 56U);
    t7 = *((char **)t6);
    t14 = (t7 + 56U);
    t15 = *((char **)t14);
    memcpy(t15, t1, 8U);
    xsi_driver_first_trans_fast_port(t5);
    xsi_set_current_line(68, ng0);
    t1 = (t0 + 2768U);
    t2 = *((char **)t1);
    t12 = *((int *)t2);
    t3 = (t12 != 255);
    if (t3 != 0)
        goto LAB17;

LAB19:
LAB18:    goto LAB3;

LAB5:    t1 = (t0 + 2152U);
    t4 = *((char **)t1);
    t10 = *((unsigned char *)t4);
    t11 = (t10 == (unsigned char)2);
    t3 = t11;
    goto LAB7;

LAB8:    xsi_set_current_line(58, ng0);
    t1 = (t0 + 4344);
    t6 = (t1 + 56U);
    t7 = *((char **)t6);
    t14 = (t7 + 56U);
    t15 = *((char **)t14);
    *((unsigned char *)t15) = (unsigned char)2;
    xsi_driver_first_trans_fast(t1);
    xsi_set_current_line(59, ng0);
    t1 = (t0 + 4408);
    t2 = (t1 + 56U);
    t4 = *((char **)t2);
    t5 = (t4 + 56U);
    t6 = *((char **)t5);
    *((unsigned char *)t6) = (unsigned char)3;
    xsi_driver_first_trans_fast(t1);
    goto LAB9;

LAB11:    xsi_set_current_line(65, ng0);
    t1 = (t0 + 2768U);
    t5 = *((char **)t1);
    t12 = *((int *)t5);
    t16 = (t12 + 1);
    t1 = (t0 + 2768U);
    t6 = *((char **)t1);
    t1 = (t6 + 0);
    *((int *)t1) = t16;
    goto LAB12;

LAB14:    t1 = (t0 + 1992U);
    t4 = *((char **)t1);
    t10 = *((unsigned char *)t4);
    t11 = (t10 == (unsigned char)2);
    t3 = t11;
    goto LAB16;

LAB17:    xsi_set_current_line(69, ng0);
    t1 = (t0 + 2768U);
    t4 = *((char **)t1);
    t16 = *((int *)t4);
    t20 = (t16 + 1);
    t1 = (t0 + 2768U);
    t5 = *((char **)t1);
    t1 = (t5 + 0);
    *((int *)t1) = t20;
    goto LAB18;

LAB20:    xsi_set_current_line(73, ng0);
    t1 = (t0 + 2768U);
    t5 = *((char **)t1);
    t12 = *((int *)t5);
    t13 = (t12 == 0);
    if (t13 != 0)
        goto LAB26;

LAB28:    xsi_set_current_line(77, ng0);
    t1 = (t0 + 4344);
    t2 = (t1 + 56U);
    t4 = *((char **)t2);
    t5 = (t4 + 56U);
    t6 = *((char **)t5);
    *((unsigned char *)t6) = (unsigned char)2;
    xsi_driver_first_trans_fast(t1);
    xsi_set_current_line(78, ng0);
    t1 = (t0 + 4408);
    t2 = (t1 + 56U);
    t4 = *((char **)t2);
    t5 = (t4 + 56U);
    t6 = *((char **)t5);
    *((unsigned char *)t6) = (unsigned char)2;
    xsi_driver_first_trans_fast(t1);

LAB27:    xsi_set_current_line(80, ng0);
    t1 = (t0 + 2312U);
    t2 = *((char **)t1);
    t8 = *((unsigned char *)t2);
    t9 = (t8 == (unsigned char)2);
    if (t9 == 1)
        goto LAB32;

LAB33:    t3 = (unsigned char)0;

LAB34:    if (t3 != 0)
        goto LAB29;

LAB31:
LAB30:    xsi_set_current_line(83, ng0);
    t1 = (t0 + 1032U);
    t2 = *((char **)t1);
    t1 = (t0 + 2768U);
    t4 = *((char **)t1);
    t12 = *((int *)t4);
    t16 = (t12 - 0);
    t17 = (t16 * 1);
    t18 = (8U * t17);
    t19 = (0U + t18);
    t1 = (t0 + 4536);
    t5 = (t1 + 56U);
    t6 = *((char **)t5);
    t7 = (t6 + 56U);
    t14 = *((char **)t7);
    memcpy(t14, t2, 8U);
    xsi_driver_first_trans_delta(t1, t19, 8U, 0LL);
    xsi_set_current_line(84, ng0);
    t1 = (t0 + 2768U);
    t2 = *((char **)t1);
    t12 = *((int *)t2);
    t3 = (t12 != 0);
    if (t3 != 0)
        goto LAB35;

LAB37:
LAB36:    goto LAB21;

LAB23:    t1 = (t0 + 1992U);
    t4 = *((char **)t1);
    t10 = *((unsigned char *)t4);
    t11 = (t10 == (unsigned char)2);
    t3 = t11;
    goto LAB25;

LAB26:    xsi_set_current_line(74, ng0);
    t1 = (t0 + 4344);
    t6 = (t1 + 56U);
    t7 = *((char **)t6);
    t14 = (t7 + 56U);
    t15 = *((char **)t14);
    *((unsigned char *)t15) = (unsigned char)3;
    xsi_driver_first_trans_fast(t1);
    xsi_set_current_line(75, ng0);
    t1 = (t0 + 4408);
    t2 = (t1 + 56U);
    t4 = *((char **)t2);
    t5 = (t4 + 56U);
    t6 = *((char **)t5);
    *((unsigned char *)t6) = (unsigned char)2;
    xsi_driver_first_trans_fast(t1);
    goto LAB27;

LAB29:    xsi_set_current_line(81, ng0);
    t1 = (t0 + 2768U);
    t5 = *((char **)t1);
    t12 = *((int *)t5);
    t16 = (t12 - 1);
    t1 = (t0 + 2768U);
    t6 = *((char **)t1);
    t1 = (t6 + 0);
    *((int *)t1) = t16;
    goto LAB30;

LAB32:    t1 = (t0 + 2152U);
    t4 = *((char **)t1);
    t10 = *((unsigned char *)t4);
    t11 = (t10 == (unsigned char)2);
    t3 = t11;
    goto LAB34;

LAB35:    xsi_set_current_line(85, ng0);
    t1 = (t0 + 2768U);
    t4 = *((char **)t1);
    t16 = *((int *)t4);
    t20 = (t16 - 1);
    t1 = (t0 + 2768U);
    t5 = *((char **)t1);
    t1 = (t5 + 0);
    *((int *)t1) = t20;
    goto LAB36;

}


extern void work_a_1752173841_3212880686_init()
{
	static char *pe[] = {(void *)work_a_1752173841_3212880686_p_0};
	xsi_register_didat("work_a_1752173841_3212880686", "isim/stack_q4_isim_beh.exe.sim/work/a_1752173841_3212880686.didat");
	xsi_register_executes(pe);
}
