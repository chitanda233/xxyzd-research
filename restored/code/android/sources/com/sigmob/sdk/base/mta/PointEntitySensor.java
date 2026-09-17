package com.sigmob.sdk.base.mta;

/* JADX INFO: loaded from: classes3.dex */
public final class PointEntitySensor extends PointEnitySigmobBase {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f3227a;
    private String b;
    private String c;

    public String getMotion_after() {
        return this.b;
    }

    public String getMotion_before() {
        return this.f3227a;
    }

    public String getMotion_interval() {
        return this.c;
    }

    public void setMotion_after(String motion_after) {
        this.b = motion_after;
    }

    public void setMotion_before(String motion_before) {
        this.f3227a = motion_before;
    }

    public void setMotion_interval(String motion_interval) {
        this.c = motion_interval;
    }
}
