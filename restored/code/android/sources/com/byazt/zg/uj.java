package com.byazt.zg;

import java.util.HashMap;
import java.util.Map;

/* JADX INFO: loaded from: classes2.dex */
public enum uj implements n {
    LEFT_PAREN("("),
    RIGHT_PAREN(")"),
    LEFT_BRACKET("["),
    RIGHT_BRACKET("]"),
    COMMA(",");


    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final Map<String, uj> f1615a;
    public final String sp;

    static {
        HashMap map = new HashMap(128);
        f1615a = map;
        for (uj ujVar : map.values()) {
            f1615a.put(ujVar.c(), ujVar);
        }
    }

    uj(String str) {
        this.sp = str;
    }

    public static boolean c(n nVar) {
        return nVar instanceof uj;
    }

    public String c() {
        return this.sp;
    }
}
