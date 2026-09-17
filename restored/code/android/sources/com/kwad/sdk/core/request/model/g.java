package com.kwad.sdk.core.request.model;

/* JADX INFO: loaded from: classes3.dex */
public class g extends com.kwad.sdk.core.response.a.a {
    public String aXA;
    public String aXB;
    public String aXy;
    public String aXz;
    public String serviceToken;
    public int thirdAge;
    public int thirdGender;
    public String thirdInterest;

    public static g NG() {
        return new g();
    }

    public final g fg(String str) {
        this.aXy = str;
        return this;
    }

    public final g fh(String str) {
        this.aXA = str;
        return this;
    }

    public final g fi(String str) {
        this.serviceToken = str;
        return this;
    }

    public final void fj(String str) {
        this.aXB = str;
    }
}
