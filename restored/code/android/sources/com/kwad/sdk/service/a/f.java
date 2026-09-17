package com.kwad.sdk.service.a;

import android.content.Context;
import com.kwad.sdk.core.response.model.AdTemplate;
import java.util.List;
import java.util.Map;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public interface f {
    com.kwad.sdk.core.response.helper.g Au();

    boolean FG();

    boolean FH();

    boolean FI();

    boolean FJ();

    String FK();

    com.kwad.sdk.core.b FL();

    List<AdTemplate> FM();

    String FN();

    JSONObject FO();

    JSONObject FP();

    Map<String, String> FQ();

    void a(String str, Map<String, String> map, String str2);

    String av(String str);

    boolean bj(AdTemplate adTemplate);

    String getApiVersion();

    int getApiVersionCode();

    String getAppId();

    String getAppName();

    Context getContext();

    String getSDKVersion();

    boolean tD();

    boolean tF();

    boolean tG();
}
