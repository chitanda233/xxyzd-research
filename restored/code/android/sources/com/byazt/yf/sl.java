package com.byazt.yf;

import com.bytedance.sdk.openadsdk.mediation.MediationConstant;

/* JADX INFO: loaded from: classes2.dex */
@com.byazt.zqa.c(c = {0, 1, 508, 158})
public abstract class sl {
    public int c;
    public String tt;
    public String uj;
    public String ve;

    public int c() {
        return this.c;
    }

    public String tt() {
        return this.tt;
    }

    public String ve() {
        return this.ve;
    }

    public String uj() {
        return this.uj;
    }

    public String n() {
        switch (this.c) {
            case 1:
                return MediationConstant.ADN_PANGLE;
            case 2:
            default:
                return "";
            case 3:
                return MediationConstant.ADN_GDT;
            case 4:
                return MediationConstant.ADN_MINTEGRAL;
            case 5:
                return MediationConstant.ADN_UNITY;
            case 6:
                return "baidu";
            case 7:
                return MediationConstant.ADN_KS;
            case 8:
                return "sigmob";
            case 9:
                return MediationConstant.ADN_KLEVIN;
            case 10:
                return MediationConstant.ADN_XIAOMI;
        }
    }
}
