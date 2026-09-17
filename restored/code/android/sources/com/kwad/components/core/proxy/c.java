package com.kwad.components.core.proxy;

import android.app.Activity;
import androidx.lifecycle.Lifecycle;
import java.lang.ref.WeakReference;

/* JADX INFO: loaded from: classes3.dex */
public final class c implements a {
    private final WeakReference<Activity> aiO;
    private com.kwad.components.core.proxy.launchdialog.d aiP;
    private com.kwad.components.core.proxy.launchdialog.d aiQ;

    public c(Activity activity) {
        this.aiO = new WeakReference<>(activity);
    }

    public final boolean d(Activity activity) {
        WeakReference<Activity> weakReference;
        if (activity == null || (weakReference = this.aiO) == null || weakReference.get() == null) {
            return false;
        }
        return this.aiO.get().equals(activity);
    }

    @Override // com.kwad.components.core.proxy.a
    public final String getPageName() {
        WeakReference<Activity> weakReference = this.aiO;
        if (weakReference == null || weakReference.get() == null) {
            return null;
        }
        return this.aiO.get().toString();
    }

    public final void a(Lifecycle.Event event) {
        this.aiP = this.aiQ;
        this.aiQ = new com.kwad.components.core.proxy.launchdialog.d(event);
    }

    @Override // com.kwad.components.core.proxy.a
    public final com.kwad.components.core.proxy.launchdialog.d vM() {
        return this.aiP;
    }

    @Override // com.kwad.components.core.proxy.a
    public final com.kwad.components.core.proxy.launchdialog.d vN() {
        return this.aiQ;
    }
}
