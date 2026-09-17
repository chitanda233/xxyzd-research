package com.unicom.online.account.kernel;

import java.util.LinkedHashMap;

/* JADX INFO: loaded from: classes4.dex */
public final class am extends LinkedHashMap {
    public am(String str, int i) {
        put("err_code", Integer.valueOf(i));
        put("err_msg", str);
    }
}
