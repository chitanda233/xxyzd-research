package com.kwad.library.b.c;

import android.content.ComponentCallbacks;
import android.content.Context;
import android.content.res.Resources;
import androidx.appcompat.view.ContextThemeWrapper;
import com.kwad.sdk.utils.ab;

/* JADX INFO: loaded from: classes3.dex */
final class f extends ContextThemeWrapper implements d {
    private String aDV;
    private Resources.Theme aEe;
    private int aEf;
    private final ContextThemeWrapper aEg;

    public f(ContextThemeWrapper contextThemeWrapper, String str) {
        super(contextThemeWrapper, contextThemeWrapper.getThemeResId());
        this.aEg = contextThemeWrapper;
        this.aDV = str;
        try {
            Object objA = ab.a((Object) contextThemeWrapper, "android.view.ContextThemeWrapper", "getThemeResId");
            if (objA != null) {
                this.aEf = ((Integer) objA).intValue();
            }
        } catch (Throwable unused) {
        }
    }

    @Override // com.kwad.library.b.c.d
    public final Context getDelegatedContext() {
        return this.aEg;
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final void registerComponentCallbacks(ComponentCallbacks componentCallbacks) {
        this.aEg.registerComponentCallbacks(componentCallbacks);
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final void unregisterComponentCallbacks(ComponentCallbacks componentCallbacks) {
        this.aEg.unregisterComponentCallbacks(componentCallbacks);
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final Context getApplicationContext() {
        return c.m(this.aEg.getApplicationContext(), this.aDV);
    }

    @Override // android.content.ContextWrapper
    public final Context getBaseContext() {
        return this.aEg;
    }

    @Override // androidx.appcompat.view.ContextThemeWrapper, android.content.ContextWrapper, android.content.Context
    public final Resources getResources() {
        return c.a(this.aEg.getResources(), this.aDV);
    }

    @Override // androidx.appcompat.view.ContextThemeWrapper, android.content.ContextWrapper, android.content.Context
    public final void setTheme(int i) {
        this.aEf = i;
        super.setTheme(i);
    }

    @Override // androidx.appcompat.view.ContextThemeWrapper, android.content.ContextWrapper, android.content.Context
    public final Resources.Theme getTheme() {
        Resources.Theme theme;
        try {
            theme = super.getTheme();
        } catch (Exception e) {
            e.printStackTrace();
            theme = null;
        }
        Resources.Theme theme2 = this.aEe;
        if (theme2 == null || theme2 == theme) {
            this.aEe = c.a(theme, theme2, this.aEf, this.aDV);
        }
        return this.aEe;
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final ClassLoader getClassLoader() {
        return c.a(super.getClassLoader(), this.aDV);
    }

    @Override // androidx.appcompat.view.ContextThemeWrapper, android.content.ContextWrapper, android.content.Context
    public final Object getSystemService(String str) {
        return c.wrapSystemService(this.aEg.getSystemService(str), str, this);
    }
}
