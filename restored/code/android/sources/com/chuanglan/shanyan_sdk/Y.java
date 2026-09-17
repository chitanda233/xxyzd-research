package com.chuanglan.shanyan_sdk;

import com.byazt.bv.BaseConstants;

/* JADX INFO: loaded from: classes2.dex */
public abstract class Y {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static int f1961a;

    public static c0 a(String str) {
        if (str == null) {
            return null;
        }
        if (str.equals("SAMSUNG")) {
            f1961a = 10;
        }
        if (str.equals("XIAOMI")) {
            f1961a = 5;
        }
        if (str.equals("BLACKSHARK")) {
            f1961a = 4;
        }
        if (str.equals("IQOO")) {
            f1961a = 1;
        }
        if (str.equals(BaseConstants.ROM_OPPO_UPPER_CONSTANT)) {
            f1961a = 0;
        }
        if (str.equals("VIVO")) {
            f1961a = 2;
        }
        if (str.equals("HONOR")) {
            f1961a = 6;
        }
        if (str.equals("MEIZU")) {
            f1961a = 9;
        }
        if (str.equals("REDMI")) {
            f1961a = 3;
        }
        if (str.equals("HUA_WEI")) {
            f1961a = 7;
        }
        if (str.equals("HUAWEI")) {
            f1961a = 8;
        }
        switch (f1961a) {
            case 0:
                return new b0();
            case 1:
            case 2:
                return new y0();
            case 3:
            case 4:
            case 5:
                return new K();
            case 6:
            case 7:
            case 8:
                return new G();
            case 9:
                return new U();
            case 10:
                return new q0();
            default:
                return null;
        }
    }
}
