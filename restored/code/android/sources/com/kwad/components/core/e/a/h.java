package com.kwad.components.core.e.a;

import android.R;
import android.app.Activity;
import android.view.View;
import android.view.ViewGroup;
import android.view.Window;
import com.kwad.sdk.core.response.model.AdTemplate;
import com.kwad.sdk.wrapper.m;
import java.lang.ref.WeakReference;

/* JADX INFO: loaded from: classes3.dex */
public final class h implements d {
    private static WeakReference<Window> Qi;
    private final com.kwad.sdk.core.c.c<Activity> Bi = new com.kwad.sdk.core.c.d() { // from class: com.kwad.components.core.e.a.h.1
        @Override // com.kwad.sdk.core.c.d, com.kwad.sdk.core.c.c
        /* JADX INFO: renamed from: onActivityDestroyed */
        public final void b(Activity activity) {
            super.b(activity);
            com.kwad.sdk.core.c.b.Mh();
            com.kwad.sdk.core.c.b.b((com.kwad.sdk.core.c.c) this);
            if (activity.equals((Activity) h.this.Qh.get())) {
                h.this.gj();
            }
        }
    };
    private g Qf;
    private b Qg;
    private WeakReference<Activity> Qh;
    private ViewGroup rE;
    private boolean rF;

    public static void a(Window window) {
        Qi = new WeakReference<>(window);
    }

    public static void pA() {
        WeakReference<Window> weakReference = Qi;
        if (weakReference != null) {
            weakReference.clear();
        }
        Qi = null;
    }

    public final boolean b(AdTemplate adTemplate, b bVar) {
        Window window;
        try {
            this.Qg = bVar;
            com.kwad.sdk.core.c.b.Mh();
            Activity currentActivity = com.kwad.sdk.core.c.b.getCurrentActivity();
            if (currentActivity != null && !currentActivity.isFinishing()) {
                WeakReference<Window> weakReference = Qi;
                if (weakReference != null) {
                    window = weakReference.get();
                } else {
                    window = currentActivity.getWindow();
                }
                View viewFindViewById = window.getDecorView().findViewById(R.id.content);
                if (!(viewFindViewById instanceof ViewGroup)) {
                    return false;
                }
                this.Qh = new WeakReference<>(currentActivity);
                this.Qf = new g(m.wrapContextIfNeed(currentActivity), adTemplate, this);
                com.kwad.sdk.core.c.b.Mh();
                com.kwad.sdk.core.c.b.a(this.Bi);
                this.rE = (ViewGroup) viewFindViewById;
                this.rE.addView(this.Qf, new ViewGroup.LayoutParams(-1, -1));
                bVar.pr();
                return true;
            }
            com.kwad.sdk.core.d.c.d("InstalledActivateViewHelper", "showInWindow fail activity:" + currentActivity);
            return false;
        } catch (Throwable th) {
            com.kwad.sdk.core.d.c.d("InstalledActivateViewHelper", "showInWindow fail error:" + th);
            com.kwad.sdk.core.d.c.printStackTrace(th);
            return false;
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void gj() {
        g gVar;
        if (this.rF) {
            return;
        }
        this.rF = true;
        this.Qg.gi();
        ViewGroup viewGroup = this.rE;
        if (viewGroup != null && (gVar = this.Qf) != null) {
            viewGroup.removeView(gVar);
        }
        com.kwad.sdk.core.c.b.Mh();
        com.kwad.sdk.core.c.b.b((com.kwad.sdk.core.c.c) this.Bi);
    }

    @Override // com.kwad.components.core.e.a.d
    public final void ps() {
        gj();
    }
}
