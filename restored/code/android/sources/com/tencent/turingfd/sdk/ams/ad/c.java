package com.tencent.turingfd.sdk.ams.ad;

import android.os.Process;

/* JADX INFO: loaded from: classes4.dex */
public abstract class c {
    public static String a() {
        StringBuilder sb = new StringBuilder();
        int iMyPid = Process.myPid();
        Dew dewB = Durian.b(iMyPid);
        if (dewB == null) {
            return sb.toString();
        }
        int i = dewB.e;
        if (i == 0) {
            return sb.toString();
        }
        if (i == iMyPid) {
            return sb.toString();
        }
        sb.append(iMyPid);
        sb.append(",");
        sb.append(dewB.b);
        sb.append(",");
        sb.append(dewB.c);
        sb.append(",");
        sb.append(i);
        sb.append(",");
        Dew dewB2 = Durian.b(i);
        if (dewB2 != null) {
            sb.append(dewB2.d);
            sb.append(",");
            sb.append(dewB2.c);
            sb.append(",");
            sb.append(dewB2.b);
        }
        return sb.toString();
    }
}
