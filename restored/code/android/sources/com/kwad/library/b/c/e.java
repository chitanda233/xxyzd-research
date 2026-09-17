package com.kwad.library.b.c;

import android.content.ComponentCallbacks;
import android.content.Context;
import android.content.res.Resources;
import android.view.ContextThemeWrapper;
import com.kwad.sdk.utils.ab;

/* JADX INFO: loaded from: classes3.dex */
final class e extends ContextThemeWrapper implements d {
    private String aDV;
    private final ContextThemeWrapper aEd;
    private Resources.Theme aEe;
    private int aEf;

    e(ContextThemeWrapper contextThemeWrapper, String str) {
        super(contextThemeWrapper, 0);
        this.aEd = contextThemeWrapper;
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
        return this.aEd;
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final void registerComponentCallbacks(ComponentCallbacks componentCallbacks) {
        this.aEd.registerComponentCallbacks(componentCallbacks);
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final void unregisterComponentCallbacks(ComponentCallbacks componentCallbacks) {
        this.aEd.unregisterComponentCallbacks(componentCallbacks);
    }

    @Override // android.content.ContextWrapper, android.content.Context
    public final Context getApplicationContext() {
        return c.m(this.aEd.getApplicationContext(), this.aDV);
    }

    @Override // android.content.ContextWrapper
    public final Context getBaseContext() {
        return this.aEd;
    }

    @Override // android.view.ContextThemeWrapper, android.content.ContextWrapper, android.content.Context
    public final Resources getResources() {
        return c.a(this.aEd.getResources(), this.aDV);
    }

    @Override // android.view.ContextThemeWrapper, android.content.ContextWrapper, android.content.Context
    public final void setTheme(int i) {
        this.aEf = i;
        super.setTheme(i);
    }

    @Override // android.view.ContextThemeWrapper, android.content.ContextWrapper, android.content.Context
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

    @Override // android.view.ContextThemeWrapper, android.content.ContextWrapper, android.content.Context
    public final Object getSystemService(String str) {
        return c.wrapSystemService(this.aEd.getSystemService(str), str, this);
    }
}
