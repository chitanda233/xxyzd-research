package com.byazt.lz;

import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes2.dex */
public interface a {
    JSONObject getCustomLocalConfig();

    boolean getHttps();

    Map<String, Object> getLocalExtra();

    sp getMediationConfigUserInfoForSegment();

    String getOpensdkVer();

    String getPublisherDid();

    boolean isOpenAdnTest();

    boolean isSupportH265();

    boolean isSupportSplashZoomout();

    boolean isWxInstalled();

    String wxAppId();
}
