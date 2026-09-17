package com.sigmob.sdk.base.mta;

/* JADX INFO: loaded from: classes3.dex */
public class PointEntityActive extends PointEntitySigmobSuper {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private String f3223a;
    private String b;
    private String c;
    private String d;

    public static PointEntityActive ActiveTracking(String category, String activeId, String duration, String activeTime) {
        PointEntityActive pointEntityActive = new PointEntityActive();
        pointEntityActive.setAc_type(PointType.WIND_ACTIVE);
        pointEntityActive.setCategory(category);
        pointEntityActive.setActive_id(activeId);
        pointEntityActive.setDuration(duration);
        pointEntityActive.setTimestamp(activeTime);
        pointEntityActive.commit();
        return pointEntityActive;
    }

    public String getActive_id() {
        return this.f3223a;
    }

    public String getDuration() {
        return this.d;
    }

    public String getRequest_id() {
        return this.b;
    }

    public String getVid() {
        return this.c;
    }

    public void setActive_id(String active_id) {
        this.f3223a = active_id;
    }

    public void setDuration(String duration) {
        this.d = duration;
    }

    public void setRequest_id(String request_id) {
        this.b = request_id;
    }

    public void setVid(String vid) {
        this.c = vid;
    }
}
