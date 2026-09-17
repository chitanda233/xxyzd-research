package com.unicom.online.account.kernel;

import java.util.HashMap;

/* JADX INFO: loaded from: classes4.dex */
public final class af {
    public int b;
    public String c;
    public String d;
    public HashMap e = new HashMap();

    public final String toString() {
        String str;
        StringBuilder sbAppend = new StringBuilder("HttpResult{statusCode=").append(this.b).append(", responseBody='");
        String str2 = this.c;
        if (str2 != null) {
            str = str2.length() > 100 ? this.c.substring(0, 100) + "..." : this.c;
        } else {
            str = "null";
        }
        return sbAppend.append(str).append("', redirectUrl='").append(this.d).append("', headers=").append(this.e.size()).append('}').toString();
    }
}
