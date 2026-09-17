package com.unicom.online.account.kernel;

import java.util.HashMap;

/* JADX INFO: loaded from: classes4.dex */
public final class bg {
    public String b;
    public long c;
    public long d;
    public long e;

    public final HashMap b() {
        HashMap map = new HashMap();
        map.put("url", this.b);
        map.put("startTime", this.c + "");
        map.put("endTime", this.d + "");
        map.put("forcedTime", this.e + "");
        return map;
    }

    public final String toString() {
        return "{url':" + this.b + "', startTime:" + this.c + ", endTime:" + this.d + '}';
    }
}
