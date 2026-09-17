package com.sigmob.sdk.mraid2;

import android.widget.LinearLayout;
import com.sigmob.sdk.base.models.BaseAdUnit;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public interface t {
    LinearLayout a(c mraid2AdContainer, int orientation);

    c a(c parentWebView, JSONObject args);

    void a();

    void a(c webView);

    void a(c webView, BaseAdUnit uri, JSONObject ext);

    void b(c webView);

    void b(c webView, JSONObject args);
}
