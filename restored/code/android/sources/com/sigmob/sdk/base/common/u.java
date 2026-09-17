package com.sigmob.sdk.base.common;

import com.sigmob.sdk.base.models.BaseAdUnit;

/* JADX INFO: loaded from: classes3.dex */
public interface u {
    boolean a(BaseAdUnit adUnit);

    boolean a(BaseAdUnit adUnit, int duration, int endTime);

    boolean a(BaseAdUnit adUnit, String event, int playheadMillis);

    boolean a(BaseAdUnit adUnit, boolean isForceShow, int playheadMillis);

    boolean b(BaseAdUnit adUnit);
}
