package com.sigmob.sdk.base.common;

import android.app.Activity;
import android.os.Bundle;
import android.view.View;

/* JADX INFO: loaded from: classes3.dex */
public interface k {
    void a();

    void a(int requestedOrientation);

    void a(Class<? extends Activity> clazz, int requestCode, Bundle extras);

    void onBackPressed();

    void onSetContentView(View view);
}
