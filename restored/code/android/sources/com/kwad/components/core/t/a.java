package com.kwad.components.core.t;

import android.content.Context;
import com.kwad.components.offline.api.core.api.OfflineOnAudioConflictListener;
import java.lang.ref.WeakReference;
import java.util.ArrayList;
import java.util.Iterator;
import java.util.List;

/* JADX INFO: loaded from: classes3.dex */
public class a {
    private static volatile a alo;
    private com.kwad.sdk.utils.j alk;
    private List<WeakReference<OfflineOnAudioConflictListener>> all = new ArrayList();
    private boolean alm = false;
    private boolean aln = false;

    static /* synthetic */ boolean a(a aVar, boolean z) {
        aVar.aln = true;
        return true;
    }

    private a(Context context) {
        init(context);
    }

    public static a aN(Context context) {
        if (alo == null) {
            synchronized (a.class) {
                if (alo == null) {
                    alo = new a(context.getApplicationContext());
                }
            }
        }
        return alo;
    }

    private void init(Context context) {
        this.alm = false;
        com.kwad.sdk.utils.j jVar = new com.kwad.sdk.utils.j(context);
        this.alk = jVar;
        jVar.c(new com.kwad.sdk.utils.j.a() { // from class: com.kwad.components.core.t.a.1
            @Override // com.kwad.sdk.utils.j.a
            public final void onAudioBeOccupied() {
                Iterator it = a.this.all.iterator();
                while (it.hasNext()) {
                    WeakReference weakReference = (WeakReference) it.next();
                    if (weakReference == null) {
                        it.remove();
                    } else {
                        OfflineOnAudioConflictListener offlineOnAudioConflictListener = (OfflineOnAudioConflictListener) weakReference.get();
                        if (offlineOnAudioConflictListener != null) {
                            offlineOnAudioConflictListener.onAudioBeOccupied();
                        } else {
                            it.remove();
                        }
                    }
                }
                a.a(a.this, true);
            }

            @Override // com.kwad.sdk.utils.j.a
            public final void onAudioBeReleased() {
                Iterator it = a.this.all.iterator();
                while (it.hasNext()) {
                    WeakReference weakReference = (WeakReference) it.next();
                    if (weakReference == null) {
                        it.remove();
                    } else {
                        OfflineOnAudioConflictListener offlineOnAudioConflictListener = (OfflineOnAudioConflictListener) weakReference.get();
                        if (offlineOnAudioConflictListener != null) {
                            offlineOnAudioConflictListener.onAudioBeReleased();
                        } else {
                            it.remove();
                        }
                    }
                }
            }
        });
    }

    public final void a(OfflineOnAudioConflictListener offlineOnAudioConflictListener) {
        this.all.add(new WeakReference<>(offlineOnAudioConflictListener));
    }

    public final void b(OfflineOnAudioConflictListener offlineOnAudioConflictListener) {
        Iterator<WeakReference<OfflineOnAudioConflictListener>> it = this.all.iterator();
        while (it.hasNext()) {
            WeakReference<OfflineOnAudioConflictListener> next = it.next();
            if (next == null || next.get() == offlineOnAudioConflictListener) {
                it.remove();
            }
        }
    }

    public final boolean bd(boolean z) {
        com.kwad.sdk.utils.j jVar = this.alk;
        if (jVar == null) {
            return false;
        }
        if (!z && this.alm) {
            return false;
        }
        this.alm = true;
        this.aln = false;
        return jVar.UC();
    }

    public final boolean wP() {
        return this.aln;
    }

    public final boolean wQ() {
        return this.alm;
    }
}
