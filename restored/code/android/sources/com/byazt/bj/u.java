package com.byazt.bj;

/* JADX INFO: loaded from: classes.dex */
public enum u {
    STATIC(0),
    RELATIVE(1),
    ABSOLUTE(2);

    public final int uj;

    u(int i) {
        this.uj = i;
    }

    public int c() {
        return this.uj;
    }

    public static u c(int i) {
        if (i == 0) {
            return STATIC;
        }
        if (i == 1) {
            return RELATIVE;
        }
        if (i == 2) {
            return ABSOLUTE;
        }
        throw new IllegalArgumentException("Unknown enum value: ".concat(String.valueOf(i)));
    }

    public static u c(String str) {
        str.hashCode();
        switch (str) {
            case "static":
                return STATIC;
            case "relative":
                return RELATIVE;
            case "absolute":
                return ABSOLUTE;
            default:
                throw new IllegalArgumentException("Unknown enum value: ".concat(String.valueOf(str)));
        }
    }
}
