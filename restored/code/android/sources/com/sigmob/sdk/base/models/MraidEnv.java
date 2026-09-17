package com.sigmob.sdk.base.models;

import com.czhj.sdk.common.ClientMetadata;
import com.czhj.volley.toolbox.StringUtil;
import com.sigmob.sdk.base.i;

/* JADX INFO: loaded from: classes3.dex */
public class MraidEnv {
    public final Boolean coppa;
    public final String version = "2.0";
    public final String sdk = StringUtil.decode(StringUtil.s);
    public final String sdkVersion = "4.25.14";
    public final String appId = ClientMetadata.getInstance().getAppPackageName();
    public final String ifa = ClientMetadata.getInstance().getAdvertisingId();
    public final Boolean limitAdTracking = Boolean.valueOf(ClientMetadata.getInstance().getLimitAdTrackingEnabled());

    public MraidEnv() {
        this.coppa = Boolean.valueOf(i.a().c() == 1);
    }
}
