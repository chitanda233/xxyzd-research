package com.sigmob.sdk.base.utils;

import android.R;
import android.app.Activity;
import android.content.Context;
import android.content.res.Resources;
import android.content.res.TypedArray;
import android.graphics.drawable.Drawable;
import android.util.DisplayMetrics;
import android.util.TypedValue;
import android.view.View;
import android.view.ViewConfiguration;
import android.view.ViewGroup;
import android.view.Window;
import android.view.WindowManager;
import android.widget.FrameLayout;
import androidx.core.view.GravityCompat;
import java.lang.reflect.Method;

/* JADX INFO: loaded from: classes3.dex */
public class r {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    public static final int f3263a = -1728053248;
    private static String b;
    private final a c;
    private boolean d;
    private boolean e;
    private boolean f;
    private boolean g;
    private View h;
    private View i;

    public static class a {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private static final String f3264a = "status_bar_height";
        private static final String b = "navigation_bar_height";
        private static final String c = "navigation_bar_height_landscape";
        private static final String d = "navigation_bar_width";
        private static final String e = "config_showNavigationBar";
        private final boolean f;
        private final boolean g;
        private final int h;
        private final int i;
        private final boolean j;
        private final int k;
        private final int l;
        private final boolean m;
        private final float n;

        private a(Activity activity, boolean translucentStatusBar, boolean traslucentNavBar) {
            Resources resources = activity.getResources();
            this.m = resources.getConfiguration().orientation == 1;
            this.n = a(activity);
            this.h = a(resources, f3264a);
            this.i = a((Context) activity);
            int iB = b(activity);
            this.k = iB;
            this.l = c(activity);
            this.j = iB > 0;
            this.f = translucentStatusBar;
            this.g = traslucentNavBar;
        }

        private float a(Activity activity) {
            DisplayMetrics displayMetrics = new DisplayMetrics();
            activity.getWindowManager().getDefaultDisplay().getRealMetrics(displayMetrics);
            return Math.min(displayMetrics.widthPixels / displayMetrics.density, displayMetrics.heightPixels / displayMetrics.density);
        }

        private int a(Context context) {
            TypedValue typedValue = new TypedValue();
            context.getTheme().resolveAttribute(R.attr.actionBarSize, typedValue, true);
            return TypedValue.complexToDimensionPixelSize(typedValue.data, context.getResources().getDisplayMetrics());
        }

        private int a(Resources res, String key) {
            int identifier = res.getIdentifier(key, "dimen", "android");
            if (identifier > 0) {
                return res.getDimensionPixelSize(identifier);
            }
            return 0;
        }

        private int b(Context context) {
            Resources resources = context.getResources();
            if (d(context)) {
                return a(resources, this.m ? b : c);
            }
            return 0;
        }

        private int c(Context context) {
            Resources resources = context.getResources();
            if (d(context)) {
                return a(resources, d);
            }
            return 0;
        }

        private boolean d(Context context) {
            Resources resources = context.getResources();
            int identifier = resources.getIdentifier(e, "bool", "android");
            if (identifier == 0) {
                return !ViewConfiguration.get(context).hasPermanentMenuKey();
            }
            boolean z = resources.getBoolean(identifier);
            if ("1".equals(r.b)) {
                return false;
            }
            if ("0".equals(r.b)) {
                return true;
            }
            return z;
        }

        public int a(boolean withActionBar) {
            return (this.f ? this.h : 0) + (withActionBar ? this.i : 0);
        }

        public boolean a() {
            return this.n >= 600.0f || this.m;
        }

        public int b() {
            return this.h;
        }

        public int c() {
            return this.i;
        }

        public boolean d() {
            return this.j;
        }

        public int e() {
            return this.k;
        }

        public int f() {
            return this.l;
        }

        public int g() {
            if (this.g && a()) {
                return this.k;
            }
            return 0;
        }

        public int h() {
            if (!this.g || a()) {
                return 0;
            }
            return this.l;
        }
    }

    static {
        try {
            Method declaredMethod = Class.forName("android.os.SystemProperties").getDeclaredMethod("get", String.class);
            declaredMethod.setAccessible(true);
            b = (String) declaredMethod.invoke(null, "qemu.hw.mainkeys");
        } catch (Throwable unused) {
            b = null;
        }
    }

    public r(Activity activity) {
        Window window = activity.getWindow();
        ViewGroup viewGroup = (ViewGroup) window.getDecorView();
        TypedArray typedArrayObtainStyledAttributes = activity.obtainStyledAttributes(new int[]{R.attr.windowTranslucentStatus, R.attr.windowTranslucentNavigation});
        try {
            this.d = typedArrayObtainStyledAttributes.getBoolean(0, false);
            this.e = typedArrayObtainStyledAttributes.getBoolean(1, false);
            typedArrayObtainStyledAttributes.recycle();
            WindowManager.LayoutParams attributes = window.getAttributes();
            if ((67108864 & attributes.flags) != 0) {
                this.d = true;
            }
            if ((attributes.flags & 134217728) != 0) {
                this.e = true;
            }
            a aVar = new a(activity, this.d, this.e);
            this.c = aVar;
            if (!aVar.d()) {
                this.e = false;
            }
            if (this.d) {
                a(activity, viewGroup);
            }
            if (this.e) {
                b(activity, viewGroup);
            }
        } catch (Throwable th) {
            typedArrayObtainStyledAttributes.recycle();
            throw th;
        }
    }

    private void a(Context context, ViewGroup decorViewGroup) {
        this.h = new View(context);
        FrameLayout.LayoutParams layoutParams = new FrameLayout.LayoutParams(-1, this.c.b());
        layoutParams.gravity = 48;
        if (this.e && !this.c.a()) {
            layoutParams.rightMargin = this.c.f();
        }
        this.h.setLayoutParams(layoutParams);
        this.h.setBackgroundColor(f3263a);
        this.h.setVisibility(8);
        decorViewGroup.addView(this.h);
    }

    private void b(Context context, ViewGroup decorViewGroup) {
        FrameLayout.LayoutParams layoutParams;
        int i;
        this.i = new View(context);
        if (this.c.a()) {
            layoutParams = new FrameLayout.LayoutParams(-1, this.c.e());
            i = 80;
        } else {
            layoutParams = new FrameLayout.LayoutParams(this.c.f(), -1);
            i = GravityCompat.END;
        }
        layoutParams.gravity = i;
        this.i.setLayoutParams(layoutParams);
        this.i.setBackgroundColor(f3263a);
        this.i.setVisibility(8);
        decorViewGroup.addView(this.i);
    }

    public a a() {
        return this.c;
    }

    public void a(float alpha) {
        b(alpha);
        c(alpha);
    }

    public void a(int color) {
        c(color);
        e(color);
    }

    public void a(Drawable drawable) {
        b(drawable);
        c(drawable);
    }

    public void a(boolean enabled) {
        this.f = enabled;
        if (this.d) {
            this.h.setVisibility(enabled ? 0 : 8);
        }
    }

    public void b(float alpha) {
        if (this.d) {
            this.h.setAlpha(alpha);
        }
    }

    public void b(int res) {
        d(res);
        f(res);
    }

    public void b(Drawable drawable) {
        if (this.d) {
            this.h.setBackgroundDrawable(drawable);
        }
    }

    public void b(boolean enabled) {
        this.g = enabled;
        if (this.e) {
            this.i.setVisibility(enabled ? 0 : 8);
        }
    }

    public boolean b() {
        return this.f;
    }

    public void c(float alpha) {
        if (this.e) {
            this.i.setAlpha(alpha);
        }
    }

    public void c(int color) {
        if (this.d) {
            this.h.setBackgroundColor(color);
        }
    }

    public void c(Drawable drawable) {
        if (this.e) {
            this.i.setBackgroundDrawable(drawable);
        }
    }

    public boolean c() {
        return this.g;
    }

    public void d(int res) {
        if (this.d) {
            this.h.setBackgroundResource(res);
        }
    }

    public void e(int color) {
        if (this.e) {
            this.i.setBackgroundColor(color);
        }
    }

    public void f(int res) {
        if (this.e) {
            this.i.setBackgroundResource(res);
        }
    }
}
