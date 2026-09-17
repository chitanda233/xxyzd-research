package com.sigmob.sdk.videoAd;

import com.sigmob.sdk.base.views.n;
import java.io.Serializable;

/* JADX INFO: loaded from: classes4.dex */
public class f implements Serializable {
    private static final long serialVersionUID = 0;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private final int f3636a;
    private final int b;
    private final n c;
    private final int d;
    private String e;
    private String f;
    private String g;
    private int h;
    private boolean i = false;
    private a j;

    f(int width, int height, int actionType, String clickThroughUrl, String deepLinkUrl, n creativeResource) {
        this.f3636a = width;
        this.b = height;
        this.d = actionType;
        this.g = deepLinkUrl;
        this.f = clickThroughUrl;
        this.c = creativeResource;
    }

    public n a() {
        return this.c;
    }

    public void a(int duration) {
        this.h = duration;
    }

    public void a(a videoConfig) {
        this.j = videoConfig;
    }
}
