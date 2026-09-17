package com.sigmob.sdk.base.mta;

/* JADX INFO: loaded from: classes3.dex */
public class PointEntityApp extends PointEntitySigmobSuper {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f3225a;
    private String b;
    private String c;
    private String d;

    public String getApp_name() {
        return this.f3225a;
    }

    public String getApp_version() {
        return this.d;
    }

    public String getPackage_name() {
        return this.b;
    }

    public String getUpdate() {
        return this.c;
    }

    public void setApp_name(String app_name) {
        this.f3225a = app_name;
    }

    public void setApp_version(String app_version) {
        this.d = app_version;
    }

    public void setPackage_name(String package_name) {
        this.b = package_name;
    }

    public void setUpdate(String update) {
        this.c = update;
    }
}
