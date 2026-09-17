package com.qq.gdt.action.f;

import com.qq.e.comm.constants.ErrorCode;
import java.util.Arrays;

/* JADX INFO: loaded from: classes3.dex */
public class d {
    public static boolean a(String str, int i) {
        if (com.qq.gdt.action.d.a().g() == null) {
            return false;
        }
        int iE = com.qq.gdt.action.b.a(com.qq.gdt.action.d.a().g()).e();
        if (iE == 0) {
            if (str != null) {
                return !"TICKET".equals(str);
            }
            return true;
        }
        if (iE == 2) {
            return false;
        }
        if (iE != 4 || Arrays.asList(4000, Integer.valueOf(ErrorCode.PrivateError.LOAD_FAIL), Integer.valueOf(ErrorCode.PrivateError.PARAM_ERROR), Integer.valueOf(ErrorCode.PrivateError.AD_DATA_DESTROYED)).contains(Integer.valueOf(i)) || str == null) {
            return true;
        }
        return !"TICKET".equals(str);
    }
}
