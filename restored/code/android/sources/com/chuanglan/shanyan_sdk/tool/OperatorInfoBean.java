package com.chuanglan.shanyan_sdk.tool;

/* JADX INFO: loaded from: classes2.dex */
public class OperatorInfoBean {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f2011a;
    private String b;
    private String c;

    public OperatorInfoBean(String str, String str2) {
        this.f2011a = str;
        this.b = str2;
    }

    public String getOperatorName() {
        return this.f2011a;
    }

    public String getOperatorSloganName() {
        return this.c;
    }

    public String getOperatorUrl() {
        return this.b;
    }

    public void setOperatorName(String str) {
        this.f2011a = str;
    }

    public void setOperatorSloganName(String str) {
        this.c = str;
    }

    public void setOperatorUrl(String str) {
        this.b = str;
    }

    public OperatorInfoBean(String str) {
        this.f2011a = str;
    }

    public OperatorInfoBean(String str, String str2, String str3) {
        this.f2011a = str;
        this.b = str2;
        this.c = str3;
    }
}
