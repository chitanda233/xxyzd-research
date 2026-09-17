package com.unicom.online.account.kernel;

import java.util.LinkedHashMap;

/* JADX INFO: loaded from: classes4.dex */
public final class al extends LinkedHashMap {
    public al() {
        put("ifProtal", u.b().b + "");
        put("InitTime", u.b().c + "");
        put("forcedTime", "1");
        if (u.b().f != null) {
            put("step1", u.b().f.b());
        }
        if (u.b().g != null) {
            put("step2", u.b().g.b());
        }
        if (u.b().h != null) {
            put("step3", u.b().h.b());
        }
        if (u.b().i != null) {
            put("step4", u.b().i.b());
        }
    }
}
