package com.baidu.mobads.sdk.internal;

import android.app.Activity;
import android.view.ViewTreeObserver;
import android.widget.RelativeLayout;
import com.kwad.sdk.core.scene.URLPackage;
import java.util.HashMap;

/* JADX INFO: loaded from: classes.dex */
class dd implements ViewTreeObserver.OnWindowFocusChangeListener {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    final /* synthetic */ RelativeLayout f497a;
    final /* synthetic */ cz b;

    dd(cz czVar, RelativeLayout relativeLayout) {
        this.b = czVar;
        this.f497a = relativeLayout;
    }

    @Override // android.view.ViewTreeObserver.OnWindowFocusChangeListener
    public void onWindowFocusChanged(boolean z) {
        if (z) {
            HashMap<String, Object> map = new HashMap<>();
            map.put("novel_activity", (Activity) this.b.i);
            map.put("banner_container", this.f497a);
            map.put("entry", Integer.valueOf(this.b.G));
            map.put(URLPackage.KEY_CHANNEL_ID, Integer.valueOf(this.b.H));
            map.put("novel_id", this.b.I);
            map.put("isnight", Boolean.valueOf(this.b.x()));
            this.b.a(cz.x, map);
        }
    }
}
