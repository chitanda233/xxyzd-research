package com.sigmob.sdk.base.mta;

/* JADX INFO: loaded from: classes3.dex */
public class PointEntityClick extends PointEnitySigmobBase {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f3226a;
    private String b;
    private String c;
    private String d;
    private String e;
    private String f;

    public String getClick_duration() {
        return this.b;
    }

    public String getIs_valid_click() {
        return this.c;
    }

    public String getLocation() {
        return this.f3226a;
    }

    public String getPressure() {
        return this.e;
    }

    public String getTouchSize() {
        return this.f;
    }

    public String getTouchType() {
        return this.d;
    }

    public void setClick_duration(String click_duration) {
        this.b = click_duration;
    }

    public void setIs_valid_click(String is_valid_click) {
        this.c = is_valid_click;
    }

    public void setLocation(String location) {
        this.f3226a = location;
    }

    public void setPressure(String pressure) {
        this.e = pressure;
    }

    public void setTouchSize(String touchSize) {
        this.f = touchSize;
    }

    public void setTouchType(String touchType) {
        this.d = touchType;
    }
}
