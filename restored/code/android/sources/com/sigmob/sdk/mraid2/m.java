package com.sigmob.sdk.mraid2;

import android.view.View;
import com.sigmob.sdk.base.models.BaseAdUnit;
import com.sigmob.windad.WindAdError;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes3.dex */
public interface m {
    void a();

    void a(View view);

    void a(c webView, BaseAdUnit adUnit, JSONObject args);

    void a(WindAdError error);

    void a(boolean useCustomClose);

    void b();

    void c();

    void d();
}
