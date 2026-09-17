package com.kwad.sdk.wrapper;

import android.content.Context;
import android.content.res.Resources;
import android.text.TextUtils;
import com.kwad.sdk.api.core.IKsAdSDK;
import com.kwad.sdk.service.ServiceProvider;
import com.kwad.sdk.utils.ab;
import com.kwad.sdk.utils.w;
import java.lang.reflect.Field;
import java.util.concurrent.atomic.AtomicBoolean;

/* JADX INFO: loaded from: classes3.dex */
public class f {
    static final /* synthetic */ boolean $assertionsDisabled = false;
    private Resources aDP;
    private Resources btI;
    private i btJ;
    private boolean btK;
    private ClassLoader btL;
    private boolean btM;
    private final AtomicBoolean mHasInit;

    /* synthetic */ f(byte b) {
        this();
    }

    private f() {
        this.mHasInit = new AtomicBoolean(false);
        this.btM = com.kwad.framework.a.a.ayS.booleanValue();
    }

    static class a {
        private static final f btN = new f(0);
    }

    public static f XZ() {
        return a.btN;
    }

    public final void init() {
        if (this.mHasInit.get()) {
            return;
        }
        try {
            if (((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).FG()) {
                if (Gi() && Yc()) {
                    this.btL = getClass().getClassLoader();
                    j.cL(Gj());
                    com.kwad.sdk.core.d.c.d("KSDY/KSPlugin", toString());
                    this.btK = true;
                } else {
                    this.btK = false;
                }
            } else if (this.btM) {
                j.cL(true);
                Yb();
                this.btL = getClass().getClassLoader();
                this.btK = true;
            }
        } catch (Throwable th) {
            ((com.kwad.sdk.service.a.e) ServiceProvider.get(com.kwad.sdk.service.a.e.class)).gatherException(th);
        }
        this.mHasInit.set(true);
    }

    public final boolean Ya() {
        return this.btM;
    }

    private boolean Gi() {
        boolean zFG = ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).FG();
        if (!this.btM || zFG) {
            return ((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).Gi();
        }
        return false;
    }

    private static boolean Gj() {
        return ((com.kwad.sdk.service.a.h) ServiceProvider.get(com.kwad.sdk.service.a.h.class)).Gj();
    }

    public final boolean Ww() {
        return this.mHasInit.get();
    }

    public final ClassLoader getClassLoader() {
        return this.btL;
    }

    public final Resources getResources() {
        boolean zFG = ((com.kwad.sdk.service.a.f) ServiceProvider.get(com.kwad.sdk.service.a.f.class)).FG();
        com.kwad.sdk.core.d.c.d("KSDY/KSPlugin", "getResources mIsInnerDexMode: " + this.btM + ", mHostResources: " + this.aDP + ", isExternal: " + zFG);
        if (this.btM && !zFG) {
            return this.aDP;
        }
        return this.btJ;
    }

    public String toString() {
        return "KSPlugin{mHostResources=" + this.aDP + ", mResResources=" + this.btI + ", mPluginResources=" + this.btJ + ", mEnable=" + this.btK + '}';
    }

    private boolean Yb() {
        Context contextUm = ServiceProvider.Um();
        if (!m.eO(contextUm)) {
            ((com.kwad.sdk.service.a.e) ServiceProvider.get(com.kwad.sdk.service.a.e.class)).gatherException(new IllegalArgumentException("KSPlugin unwrapContextIfNeed fail"));
            return false;
        }
        this.aDP = contextUm.getResources();
        return true;
    }

    private boolean Yc() {
        Object objA;
        try {
            Context contextUm = ServiceProvider.Um();
            if (!m.eO(contextUm)) {
                ((com.kwad.sdk.service.a.e) ServiceProvider.get(com.kwad.sdk.service.a.e.class)).gatherException(new IllegalArgumentException("KSPlugin unwrapContextIfNeed fail"));
                return false;
            }
            Class<?> cls = Class.forName("com.kwad.sdk.api.loader.Loader", false, getClass().getClassLoader());
            Resources resourcesA = null;
            Object objInvoke = cls.getDeclaredMethod("get", new Class[0]).invoke(null, new Object[0]);
            for (Field field : cls.getDeclaredFields()) {
                if (field.getType() != IKsAdSDK.class && field.getType() != Context.class && field.getType() != AtomicBoolean.class && (objA = ab.a(field, objInvoke)) != null) {
                    for (Field field2 : objA.getClass().getDeclaredFields()) {
                        if (field2.getType() == Resources.class) {
                            field2.setAccessible(true);
                            String strY = com.kwad.sdk.wrapper.a.y(contextUm, w.bn(contextUm));
                            if (!TextUtils.isEmpty(strY)) {
                                resourcesA = com.kwad.library.b.b.b.a(contextUm, contextUm.getResources(), strY);
                                com.kwad.sdk.core.d.c.d("KSDY/KSPlugin", "use merge res ");
                            } else {
                                com.kwad.sdk.core.d.c.d("KSDY/KSPlugin", "find dynamicFile failed");
                            }
                            if (resourcesA == null) {
                                resourcesA = (Resources) field2.get(objA);
                            }
                            Resources resources = contextUm.getResources();
                            i iVar = new i(resourcesA, resources);
                            ab.a(field2, objA, iVar);
                            this.aDP = resources;
                            this.btI = resourcesA;
                            this.btJ = iVar;
                            return true;
                        }
                    }
                }
            }
            return false;
        } catch (Throwable th) {
            ((com.kwad.sdk.service.a.e) ServiceProvider.get(com.kwad.sdk.service.a.e.class)).gatherException(th);
        }
    }
}
