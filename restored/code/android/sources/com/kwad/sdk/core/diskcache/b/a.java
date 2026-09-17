package com.kwad.sdk.core.diskcache.b;

import android.content.Context;
import android.text.TextUtils;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.service.a.f;
import com.kwad.sdk.utils.az;
import com.kwad.sdk.utils.bg;
import java.io.File;
import java.io.IOException;

/* JADX INFO: loaded from: classes3.dex */
public final class a {
    private com.kwad.sdk.core.diskcache.a.a aRU;

    /* JADX INFO: renamed from: com.kwad.sdk.core.diskcache.b.a$a, reason: collision with other inner class name */
    static final class C0507a {
        static final a aRV = new a(0);
    }

    /* synthetic */ a(byte b) {
        this();
    }

    private a() {
    }

    private synchronized void init(Context context) {
        if (this.aRU != null || context == null) {
            return;
        }
        try {
            this.aRU = com.kwad.sdk.core.diskcache.a.a.a(bg.ed(context), 1, 1, 209715200L);
        } catch (Throwable unused) {
        }
    }

    public static a LI() {
        return C0507a.aRV;
    }

    public final void eo(String str) {
        if (LJ() || TextUtils.isEmpty(str)) {
            return;
        }
        b.a(this.aRU, str, c.eq(str));
    }

    public final boolean a(String str, com.kwad.sdk.core.network.a.a.C0515a c0515a) {
        File fileEp;
        if (!LJ() && !TextUtils.isEmpty(str)) {
            String strEq = c.eq(str);
            if (b.a(this.aRU, str, strEq, c0515a) && (fileEp = ep(strEq)) != null && fileEp.exists()) {
                return true;
            }
        }
        return false;
    }

    public final boolean b(String str, String str2, com.kwad.sdk.core.network.a.a.C0515a c0515a) {
        File fileEp;
        if (!LJ() && !TextUtils.isEmpty(str)) {
            String strEq = c.eq(str2);
            if (b.a(this.aRU, str, strEq, c0515a) && (fileEp = ep(strEq)) != null && fileEp.exists()) {
                return true;
            }
        }
        return false;
    }

    public final File cM(String str) {
        if (LJ() || TextUtils.isEmpty(str)) {
            return null;
        }
        return ep(c.eq(str));
    }

    private File ep(String str) {
        if (LJ() || TextUtils.isEmpty(str)) {
            return null;
        }
        return b.a(this.aRU, str);
    }

    public final boolean remove(String str) {
        if (LJ()) {
            return false;
        }
        try {
            az.aB(str, "cacheKey is not allowed empty");
            return this.aRU.remove(c.eq(str));
        } catch (IOException unused) {
            return false;
        }
    }

    public final void delete() {
        if (LJ()) {
            return;
        }
        try {
            this.aRU.delete();
        } catch (IOException unused) {
        }
    }

    private boolean LJ() {
        init(((f) ServiceProvider.get(f.class)).getContext());
        return this.aRU == null;
    }
}
