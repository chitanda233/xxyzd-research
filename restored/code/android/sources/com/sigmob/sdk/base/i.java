package com.sigmob.sdk.base;

import android.content.Context;
import com.czhj.sdk.common.Constants;
import com.czhj.sdk.logger.SigmobLog;
import com.sigmob.sdk.base.common.ad;
import com.sigmob.sdk.base.utils.y;

/* JADX INFO: loaded from: classes3.dex */
public class i {
    private static i e;
    private int b;
    private int d;
    private boolean f;
    private int g;
    private Boolean h;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private boolean f3216a = true;
    private boolean c = true;

    private i() {
        Context contextE = com.sigmob.sdk.b.e();
        this.b = y.a(contextE, (String) null, Constants.AGE_RESTRICTED_STATUS, 0);
        this.d = y.a(contextE, (String) null, Constants.USER_AGE, 0);
        this.g = y.a(contextE, (String) null, Constants.GDPR_CONSENT_STATUS, 0);
        this.f = y.a(contextE, (String) null, Constants.EXT_GDPR_REGION, false);
    }

    public static synchronized i a() {
        if (e == null) {
            synchronized (i.class) {
                e = new i();
            }
        }
        return e;
    }

    public void a(int userAge, boolean sendTrack) {
        this.d = userAge;
        y.b(com.sigmob.sdk.b.e(), (String) null, Constants.USER_AGE, this.d);
        if (sendTrack) {
            ad.a(userAge);
        }
    }

    public void a(Boolean extGDPRRegion) {
        if (extGDPRRegion != null) {
            y.b(com.sigmob.sdk.b.e(), (String) null, Constants.EXT_GDPR_REGION, extGDPRRegion.booleanValue());
            this.f = extGDPRRegion.booleanValue();
        }
        if (i()) {
            ad.a(g(), h());
            ad.b(this.c);
            ad.a(this.f3216a);
            ad.b(this.b);
            ad.a(this.d);
        }
    }

    public void a(boolean isAdult, boolean sendTrack) {
        SigmobLog.i("PrivacyManager -> setAdult " + isAdult);
        this.f3216a = isAdult;
        if (sendTrack) {
            ad.a(isAdult);
        }
    }

    public int b() {
        return this.d;
    }

    public void b(int age_restricted, boolean sendTrack) {
        this.b = age_restricted;
        y.b(com.sigmob.sdk.b.e(), (String) null, Constants.AGE_RESTRICTED_STATUS, this.b);
        if (sendTrack) {
            ad.b(age_restricted);
        }
    }

    public void b(boolean isPersonalizedAdvertisingOn, boolean sendTrack) {
        if (this.h == null) {
            this.h = Boolean.valueOf(isPersonalizedAdvertisingOn);
        }
        SigmobLog.i("PrivacyManager -> setPersonalized " + isPersonalizedAdvertisingOn);
        this.c = isPersonalizedAdvertisingOn;
        if (sendTrack) {
            ad.b(isPersonalizedAdvertisingOn);
        }
    }

    public int c() {
        return this.b;
    }

    public void c(int gdprConSentStatus, boolean sendtrack) {
        this.g = gdprConSentStatus;
        y.b(com.sigmob.sdk.b.e(), (String) null, Constants.GDPR_CONSENT_STATUS, gdprConSentStatus);
        if (sendtrack) {
            ad.a(g(), h());
        }
    }

    public boolean d() {
        return this.f3216a;
    }

    public boolean e() {
        return this.c;
    }

    public boolean f() {
        Boolean bool = this.h;
        return bool == null || bool.booleanValue() != this.c;
    }

    public int g() {
        return this.g;
    }

    public boolean h() {
        return this.f;
    }

    public boolean i() {
        return (g() == 1) || !h();
    }
}
