package com.chuanglan.shanyan_sdk.view;

import android.app.Activity;
import android.content.Context;
import android.content.Intent;
import android.content.res.Configuration;
import android.graphics.Typeface;
import android.graphics.drawable.Drawable;
import android.graphics.drawable.GradientDrawable;
import android.os.Build;
import android.os.Bundle;
import android.os.SystemClock;
import android.view.KeyEvent;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.CompoundButton;
import android.widget.ImageView;
import android.widget.RelativeLayout;
import android.widget.TextView;
import android.window.OnBackInvokedCallback;
import com.chuanglan.shanyan_sdk.AbstractC0597c;
import com.chuanglan.shanyan_sdk.AbstractC0600f;
import com.chuanglan.shanyan_sdk.AbstractC0606l;
import com.chuanglan.shanyan_sdk.AbstractC0614t;
import com.chuanglan.shanyan_sdk.C0615u;
import com.chuanglan.shanyan_sdk.C0616v;
import com.chuanglan.shanyan_sdk.E;
import com.chuanglan.shanyan_sdk.EnumC0611q;
import com.chuanglan.shanyan_sdk.F;
import com.chuanglan.shanyan_sdk.O;
import com.chuanglan.shanyan_sdk.Q;
import com.chuanglan.shanyan_sdk.S;
import com.chuanglan.shanyan_sdk.e0;
import com.chuanglan.shanyan_sdk.f0;
import com.chuanglan.shanyan_sdk.listener.AuthPageActionListener;
import com.chuanglan.shanyan_sdk.listener.OpenLoginAuthCallbaks;
import com.chuanglan.shanyan_sdk.listener.ShanYanCustomInterface;
import com.chuanglan.shanyan_sdk.r0;
import com.chuanglan.shanyan_sdk.s0;
import com.chuanglan.shanyan_sdk.t0;
import com.chuanglan.shanyan_sdk.tool.ShanYanUIConfig;
import com.chuanglan.shanyan_sdk.w0;
import com.chuanglan.shanyan_sdk.x0;
import com.chuanglan.shanyan_sdk.z0;
import java.lang.ref.WeakReference;
import java.util.ArrayList;

/* JADX INFO: loaded from: classes2.dex */
public class ShanYanOneKeyActivity extends Activity {
    public static WeakReference<ShanYanOneKeyActivity> mLoginActivityWeakReference;
    private int A;
    private OpenLoginAuthCallbaks C;
    private OnBackInvokedCallback D;

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private TextView f2021a;
    private TextView b;
    private TextView c;
    private TextView d;
    private Button e;
    private ImageView f;
    private ImageView g;
    private Context h;
    private ShanYanUIConfig i;
    private RelativeLayout j;
    private RelativeLayout k;
    private RelativeLayout l;
    private RelativeLayout m;
    private RelativeLayout n;
    private CheckBox q;
    private ViewGroup r;
    private ViewGroup s;
    private ViewGroup t;
    private ViewGroup u;
    private C0615u v;
    private long w;
    private long x;
    private long y;
    private String z;
    private ArrayList o = null;
    private s0 p = null;
    private int B = 0;

    class a implements OnBackInvokedCallback {
        a() {
        }

        @Override // android.window.OnBackInvokedCallback
        public void onBackInvoked() {
            Q.a("ProcessShanYanLogger", "ShanYanOneKeyActivity onBackInvoked");
            ShanYanOneKeyActivity shanYanOneKeyActivity = ShanYanOneKeyActivity.this;
            shanYanOneKeyActivity.a(shanYanOneKeyActivity.i.isBackPressedAvailable());
        }
    }

    class b implements View.OnClickListener {
        b() {
        }

        @Override // android.view.View.OnClickListener
        public void onClick(View view) {
            ShanYanOneKeyActivity.this.a(true);
        }
    }

    class c implements View.OnClickListener {
        c() {
        }

        @Override // android.view.View.OnClickListener
        public void onClick(View view) {
            try {
                if (ShanYanOneKeyActivity.this.q.isChecked()) {
                    ShanYanOneKeyActivity.this.o();
                } else {
                    ShanYanOneKeyActivity.this.p();
                }
            } catch (Exception e) {
                ShanYanOneKeyActivity.this.a("LoginButtonClick Exception=" + e);
            }
        }
    }

    class d implements View.OnClickListener {
        d() {
        }

        @Override // android.view.View.OnClickListener
        public void onClick(View view) {
            ShanYanOneKeyActivity.this.q.performClick();
        }
    }

    class e implements CompoundButton.OnCheckedChangeListener {
        e() {
        }

        @Override // android.widget.CompoundButton.OnCheckedChangeListener
        public void onCheckedChanged(CompoundButton compoundButton, boolean z) {
            if (z) {
                ShanYanOneKeyActivity shanYanOneKeyActivity = ShanYanOneKeyActivity.this;
                shanYanOneKeyActivity.a(shanYanOneKeyActivity.q, ShanYanOneKeyActivity.this.i.getCheckedImgPath(), "umcsdk_check_image");
                ShanYanOneKeyActivity.this.a(2, 1, "选中协议复选框");
            } else {
                ShanYanOneKeyActivity shanYanOneKeyActivity2 = ShanYanOneKeyActivity.this;
                shanYanOneKeyActivity2.a(shanYanOneKeyActivity2.q, ShanYanOneKeyActivity.this.i.getUncheckedImgPath(), "umcsdk_uncheck_image");
                ShanYanOneKeyActivity.this.a(2, 0, "取消选中协议复选框");
            }
        }
    }

    class f implements View.OnClickListener {
        f() {
        }

        @Override // android.view.View.OnClickListener
        public void onClick(View view) {
            if (ShanYanOneKeyActivity.this.p.f1999a) {
                ShanYanOneKeyActivity.this.finish();
            }
            if (ShanYanOneKeyActivity.this.p.g != null) {
                ShanYanOneKeyActivity.this.p.g.onClick(ShanYanOneKeyActivity.this.h, view);
            }
        }
    }

    private void A() {
        View view;
        s0 s0Var = this.p;
        if (s0Var != null && (view = s0Var.f) != null && ((View) view.getParent()) != null) {
            this.l.removeView(this.p.f);
        }
        if (this.i.getRelativeCustomView() != null) {
            this.p = this.i.getRelativeCustomView();
            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, -1);
            layoutParams.setMargins(AbstractC0597c.a(this.h, this.p.b), AbstractC0597c.a(this.h, this.p.c), AbstractC0597c.a(this.h, this.p.d), AbstractC0597c.a(this.h, this.p.e));
            layoutParams.addRule(14);
            layoutParams.addRule(3, O.a(this).b("shanyan_view_bt_one_key_login"));
            layoutParams.addRule(2, O.a(this).b("shanyan_view_privacy_include"));
            this.p.f.setLayoutParams(layoutParams);
            this.l.addView(this.p.f, 0);
            this.p.f.setOnClickListener(new f());
        }
    }

    private void B() {
        Q.a("ProcessShanYanLogger", "setViews");
        H();
        n();
        w();
        x();
        A();
        e();
        C();
    }

    private void C() {
        try {
            if (!this.i.isBackNavigationEnabled() || Build.VERSION.SDK_INT < 33) {
                return;
            }
            this.D = new a();
            getOnBackInvokedDispatcher().registerOnBackInvokedCallback(0, this.D);
        } catch (Exception e2) {
            e2.printStackTrace();
        }
    }

    private void D() {
        if (this.i.isNavReturnImgHidden()) {
            this.k.setVisibility(8);
            return;
        }
        this.k.setVisibility(0);
        a(this.f, this.i.getNavReturnImgPath(), "umcsdk_return_bg");
        w0.a(this.h, this.k, this.i.getNavReturnBtnOffsetX(), this.i.getNavReturnBtnOffsetY(), this.i.getNavReturnBtnOffsetRightX(), this.i.getReturnBtnWidth(), this.i.getReturnBtnHeight(), this.f);
    }

    private void E() {
        if (AbstractC0600f.a(this.i.getNavText())) {
            this.b.setVisibility(8);
            return;
        }
        this.b.setVisibility(0);
        this.b.setText(this.i.getNavText());
        this.b.setTextColor(this.i.getNavTextColor());
        this.b.setTextSize(this.i.isTextSizeIsdp() ? 1 : 2, this.i.getNavTextSize());
        this.b.setTypeface(Typeface.defaultFromStyle(this.i.isNavTextBold() ? 1 : 0));
    }

    private void F() {
        if (this.i.isAuthNavHidden()) {
            this.j.setVisibility(8);
            return;
        }
        this.j.setVisibility(0);
        this.j.setBackgroundColor(this.i.getNavColor());
        if (this.i.isAuthNavTransparent()) {
            this.j.getBackground().setAlpha(0);
        }
        E();
        D();
    }

    private void G() {
        boolean zIsCustomPrivacyAlertViewAutoShow = this.i.isCustomPrivacyAlertViewAutoShow();
        Q.a("UIShanYanLogger", "showPrivacyToast", Boolean.valueOf(this.u == null), Boolean.valueOf(this.i.isCustomPrivacyAlertViewAutoShow()));
        ViewGroup viewGroup = this.u;
        if (viewGroup != null && zIsCustomPrivacyAlertViewAutoShow) {
            viewGroup.setVisibility(0);
            this.u.setOnClickListener(null);
        }
        if (this.i.isPrivacyToastHidden()) {
            return;
        }
        if (this.i.getPrivacyCustomToast() != null) {
            this.i.getPrivacyCustomToast().show();
        } else if (this.i.getPrivacyCustomToastText() != null) {
            AbstractC0597c.a(this.h, this.i.getPrivacyCustomToastText());
        } else {
            AbstractC0597c.a(this.h, "请勾选协议");
        }
    }

    private void H() {
        com.chuanglan.shanyan_sdk.tool.a aVarB = com.chuanglan.shanyan_sdk.tool.a.b();
        ShanYanUIConfig shanYanUIConfigA = aVarB.a();
        ShanYanUIConfig shanYanUIConfigC = aVarB.c();
        if (shanYanUIConfigC == null) {
            shanYanUIConfigC = shanYanUIConfigA;
        }
        if (this.A != 1) {
            shanYanUIConfigA = shanYanUIConfigC;
        }
        this.i = shanYanUIConfigA;
    }

    private void g() {
        if (this.i.getLogBtnBackgroundColor() == -1) {
            a(this.e, this.i.getLogBtnBackgroundPath(), "umcsdk_login_btn_bg");
            return;
        }
        GradientDrawable gradientDrawable = new GradientDrawable();
        gradientDrawable.setCornerRadius(AbstractC0597c.a(this.h, 25.0f));
        gradientDrawable.setColor(this.i.getLogBtnBackgroundColor());
        this.e.setBackground(gradientDrawable);
    }

    private void h() {
        if (this.i.isLogoHidden()) {
            this.g.setVisibility(8);
            return;
        }
        this.g.setVisibility(0);
        if (this.i.getLogoImgPath() != null) {
            this.g.setImageDrawable(this.i.getLogoImgPath());
        } else {
            this.g.setBackgroundResource(this.h.getResources().getIdentifier("umcsdk_mobile_logo", "drawable", C0616v.g().c(this.h)));
        }
        a(this.g, this.i.getLogoImgPath(), "umcsdk_mobile_logo");
        w0.a(this.h, this.g, this.i.getLogoOffsetX(), this.i.getLogoOffsetY(), this.i.getLogoOffsetBottomY(), this.i.getLogoWidth(), this.i.getLogoHeight());
    }

    private void i() {
        this.f2021a.setText(AbstractC0606l.p);
        this.f2021a.setTextColor(this.i.getNumberColor());
        this.f2021a.setTextSize(this.i.isTextSizeIsdp() ? 1 : 2, this.i.getNumberSize());
        this.f2021a.setTypeface(Typeface.defaultFromStyle(this.i.isNumberBold() ? 1 : 0));
        w0.a(this.h, this.f2021a, this.i.getNumFieldOffsetX(), this.i.getNumFieldOffsetY(), this.i.getNumFieldOffsetBottomY(), this.i.getNumFieldWidth(), this.i.getNumFieldHeight());
    }

    private void j() {
        if (this.i.isCheckBoxHidden()) {
            this.m.setVisibility(8);
            return;
        }
        this.m.setVisibility(0);
        w0.a(this.h, this.m, this.i.getCbMarginLeft(), this.i.getCbMarginTop(), this.i.getCbMarginRigth(), this.i.getCbMarginBottom(), this.i.getCbLeft(), this.i.getCbTop());
        w0.a(this.h, this.q, this.i.getCheckboxWidth(), this.i.getCheckboxWidth());
        if (this.i.isPrivacyState()) {
            this.q.setChecked(true);
            a(this.q, this.i.getCheckedImgPath(), "umcsdk_check_image");
        } else {
            this.q.setChecked(false);
            a(this.q, this.i.getUncheckedImgPath(), "umcsdk_uncheck_image");
        }
    }

    private void k() {
        t0.h().a(this.q);
        j();
        this.d.setTextSize(this.i.isTextSizeIsdp() ? 1 : 2, this.i.getPrivacyTextSize());
        this.d.setTypeface(Typeface.defaultFromStyle(this.i.isPrivacyTextBold() ? 1 : 0));
        if (this.i.getPrivacyTextLineSpacingAdd() != -1.0f && this.i.getPrivacyTextLineSpacingMult() != -1.0f) {
            this.d.setLineSpacing(this.i.getPrivacyTextLineSpacingAdd(), this.i.getPrivacyTextLineSpacingMult());
        }
        AbstractC0614t.a(this.i, this.h, this.d, this.r, this.z);
    }

    private void l() {
        if (this.i.isSloganHidden()) {
            this.c.setVisibility(8);
            return;
        }
        this.c.setVisibility(0);
        this.c.setText(f0.c(this.z));
        this.c.setTextColor(this.i.getSloganTextColor());
        this.c.setTextSize(this.i.isTextSizeIsdp() ? 1 : 2, this.i.getSloganTextSize());
        this.c.setTypeface(Typeface.defaultFromStyle(this.i.isSloganTextBold() ? 1 : 0));
        w0.a(this.h, this.c, this.i.getSloganOffsetX(), this.i.getSloganOffsetY(), this.i.getSloganOffsetBottomY());
    }

    private void m() {
        if (this.i.getAuthBgVideoPath() == null) {
            C0615u c0615u = this.v;
            if (c0615u != null) {
                this.n.removeView(c0615u);
                this.v = null;
                return;
            }
            return;
        }
        if (this.v == null) {
            C0615u c0615u2 = new C0615u(this.h);
            this.v = c0615u2;
            c0615u2.setOnCompletionListener(null);
            this.v.setOnPreparedListener(null);
            this.v.setOnErrorListener(null);
            this.n.addView(this.v, 0, new RelativeLayout.LayoutParams(-1, -1));
        }
        w0.a(this.v, this.h, this.i.getAuthBgVideoPath());
    }

    private void n() {
        z0.a(this, this.i.isAuthFlagSecureEnable());
        v();
        if (this.i.isDialogTheme()) {
            z0.a(this, this.i);
            z0.a(this, this.i.getDialogDimAmount());
        }
        z0.b(this, this.i.isFullScreen());
        if (!this.i.isFullScreen()) {
            z0.c(this, this.i);
        }
        z0.a(this.n, this.i.isFitsSystemWindows());
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void o() {
        Q.a("ProcessShanYanLogger", "handleCheckedLogin count", Integer.valueOf(this.B));
        this.e.setClickable(false);
        this.B++;
        z();
        E.a().a(4, System.currentTimeMillis(), SystemClock.uptimeMillis());
        a(3, 1, "点击登录按钮（协议框已勾选）");
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void p() {
        Q.a("ProcessShanYanLogger", "handleUncheckedLogin");
        this.s.setVisibility(8);
        G();
        a(3, 0, "点击登录按钮（协议框未勾选）");
    }

    private void q() {
        String str = AbstractC0606l.m;
        this.z = str;
        AbstractC0606l.q = str;
        Intent intent = getIntent();
        this.y = intent.getLongExtra("beginTime", System.currentTimeMillis());
        this.w = intent.getLongExtra("stepStartTime", SystemClock.uptimeMillis());
        this.x = intent.getLongExtra("methodStartTime", System.currentTimeMillis());
    }

    private void r() {
        mLoginActivityWeakReference = new WeakReference<>(this);
        this.h = getApplicationContext();
        this.A = getResources().getConfiguration().orientation;
        this.i = com.chuanglan.shanyan_sdk.tool.a.b().a();
        this.t = (ViewGroup) getWindow().getDecorView();
        this.n = (RelativeLayout) findViewById(O.a(this.h).b("shanyan_view_login_layout"));
        this.l = (RelativeLayout) findViewById(O.a(this.h).b("shanyan_view_login_boby"));
        this.j = (RelativeLayout) findViewById(O.a(this.h).b("shanyan_view_navigationbar_include"));
        this.f = (ImageView) findViewById(O.a(this.h).b("shanyan_view_navigationbar_back"));
        this.k = (RelativeLayout) findViewById(O.a(this.h).b("shanyan_view_navigationbar_back_root"));
        this.b = (TextView) findViewById(O.a(this.h).b("shanyan_view_navigationbar_title"));
        this.g = (ImageView) findViewById(O.a(this.h).b("shanyan_view_log_image"));
        this.f2021a = (TextView) findViewById(O.a(this.h).b("shanyan_view_tv_per_code"));
        this.e = (Button) findViewById(O.a(this.h).b("shanyan_view_bt_one_key_login"));
        this.c = (TextView) findViewById(O.a(this.h).b("shanyan_view_identify_tv"));
        this.r = (ViewGroup) findViewById(O.a(this.h).b("shanyan_view_privacy_include"));
        this.d = (TextView) findViewById(O.a(this.h).b("shanyan_view_privacy_text"));
        this.q = (CheckBox) findViewById(O.a(this.h).b("shanyan_view_privacy_checkbox"));
        this.m = (RelativeLayout) findViewById(O.a(this.h).b("shanyan_view_privacy_checkbox_rootlayout"));
    }

    private void s() {
        if (AbstractC0606l.T != null) {
            Q.a("ProcessShanYanLogger", "ShanYanOneKeyActivity onActivityCreated");
            AbstractC0606l.T.onActivityCreated(this);
        }
    }

    private void t() {
        OpenLoginAuthCallbaks openLoginAuthCallbaks = this.C;
        if (openLoginAuthCallbaks != null) {
            EnumC0611q enumC0611q = EnumC0611q.OPEN_PAGE_SUCCESS_CODE;
            openLoginAuthCallbaks.openPageSuccessed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c(), this.y, this.w, this.x);
        }
    }

    private void u() {
        if (this.o.isEmpty()) {
            return;
        }
        for (r0 r0Var : this.o) {
            if (((View) r0Var.c.getParent()) != null) {
                if (r0Var.b) {
                    this.j.removeView(r0Var.c);
                } else {
                    this.l.removeView(r0Var.c);
                }
            }
        }
    }

    private void v() {
        String enterAnim = this.i.getEnterAnim();
        String exitAnim = this.i.getExitAnim();
        if (enterAnim == null && exitAnim == null) {
            return;
        }
        overridePendingTransition(O.a(this.h).a(enterAnim), O.a(this.h).a(exitAnim));
    }

    private void w() {
        c();
        F();
        h();
        i();
        f();
        l();
        k();
    }

    private void x() {
        if (this.o == null) {
            this.o = new ArrayList();
        }
        u();
        if (this.i.getCustomViews() != null) {
            this.o.clear();
            this.o.addAll(this.i.getCustomViews());
            for (int i = 0; i < this.o.size(); i++) {
                final r0 r0Var = (r0) this.o.get(i);
                if (r0Var.b) {
                    this.j.addView(r0Var.c, 0);
                } else {
                    this.l.addView(r0Var.c, 0);
                }
                r0Var.c.setOnClickListener(new View.OnClickListener() { // from class: com.chuanglan.shanyan_sdk.view.ShanYanOneKeyActivity$$ExternalSyntheticLambda0
                    @Override // android.view.View.OnClickListener
                    public final void onClick(View view) {
                        this.f$0.a(r0Var, view);
                    }
                });
            }
        }
    }

    private void y() {
        this.C = new e0(this.h);
        this.k.setOnClickListener(new b());
        this.e.setOnClickListener(new c());
        this.m.setOnClickListener(new d());
        this.q.setOnCheckedChangeListener(new e());
    }

    private void z() {
        ViewGroup viewGroup = this.s;
        if (viewGroup != null) {
            viewGroup.setVisibility(0);
            this.s.setOnClickListener(null);
        }
    }

    @Override // android.app.Activity
    public void finish() {
        super.finish();
        try {
            v();
        } catch (Exception e2) {
            e2.printStackTrace();
            Q.d("ExceptionShanYanLogger", "ShanYanOneKeyActivity finish Exception=", e2);
        }
    }

    @Override // android.app.Activity, android.content.ComponentCallbacks
    public void onConfigurationChanged(Configuration configuration) {
        super.onConfigurationChanged(configuration);
        try {
            int i = configuration.orientation;
            Q.a("UIShanYanLogger", "configurationChanged", Integer.valueOf(i), Integer.valueOf(this.A));
            if (this.A != i) {
                this.A = i;
                B();
            }
        } catch (Exception e2) {
            e2.printStackTrace();
            Q.d("ExceptionShanYanLogger", "ShanYanOneKeyActivity onConfigurationChanged Exception=", e2);
        }
    }

    @Override // android.app.Activity
    protected void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        try {
            if (bundle != null) {
                Q.a("ProcessShanYanLogger", "recreate and savedInstanceState is not null");
                finish();
                return;
            }
            setContentView(O.a(this).c("layout_shanyan_login"));
            r();
            q();
            y();
            B();
            t();
            s();
        } catch (Exception e2) {
            b("onCreate Exception=" + e2);
            finish();
        }
    }

    @Override // android.app.Activity
    protected void onDestroy() {
        super.onDestroy();
        try {
            AbstractC0606l.U.set(true);
            if (this.D != null && Build.VERSION.SDK_INT >= 33) {
                getOnBackInvokedDispatcher().unregisterOnBackInvokedCallback(this.D);
                this.D = null;
            }
            RelativeLayout relativeLayout = this.n;
            if (relativeLayout != null) {
                x0.a(relativeLayout);
                this.n = null;
            }
            ArrayList arrayList = this.o;
            if (arrayList != null) {
                arrayList.clear();
                this.o = null;
            }
            RelativeLayout relativeLayout2 = this.j;
            if (relativeLayout2 != null) {
                x0.a(relativeLayout2);
                this.j = null;
            }
            RelativeLayout relativeLayout3 = this.l;
            if (relativeLayout3 != null) {
                x0.a(relativeLayout3);
                this.l = null;
            }
            C0615u c0615u = this.v;
            if (c0615u != null) {
                c0615u.setOnCompletionListener(null);
                this.v.setOnPreparedListener(null);
                this.v.setOnErrorListener(null);
                this.v = null;
            }
            Button button = this.e;
            if (button != null) {
                x0.a(button);
                this.e = null;
            }
            CheckBox checkBox = this.q;
            if (checkBox != null) {
                checkBox.setOnCheckedChangeListener(null);
                this.q.setOnClickListener(null);
                this.q = null;
            }
            RelativeLayout relativeLayout4 = this.k;
            if (relativeLayout4 != null) {
                x0.a(relativeLayout4);
                this.k = null;
            }
            RelativeLayout relativeLayout5 = this.m;
            if (relativeLayout5 != null) {
                x0.a(relativeLayout5);
                this.m = null;
            }
            ViewGroup viewGroup = this.t;
            if (viewGroup != null) {
                x0.a(viewGroup);
                this.t = null;
            }
            com.chuanglan.shanyan_sdk.tool.a.b().d();
            ViewGroup viewGroup2 = this.r;
            if (viewGroup2 != null) {
                x0.a(viewGroup2);
                this.r = null;
            }
            t0.h().e();
            this.f2021a = null;
            this.f = null;
            this.b = null;
            this.g = null;
            this.c = null;
            this.d = null;
            this.l = null;
            F.c().a();
            if (AbstractC0606l.T != null) {
                Q.a("ProcessShanYanLogger", "ShanYanOneKeyActivity onActivityDestroyed");
                AbstractC0606l.T.onActivityDestroyed(this);
            }
        } catch (Exception e2) {
            e2.printStackTrace();
            Q.d("ExceptionShanYanLogger", "onDestroy Exception", e2);
        }
    }

    @Override // android.app.Activity, android.view.KeyEvent.Callback
    public boolean onKeyDown(int i, KeyEvent keyEvent) {
        if (i != 4 || keyEvent.getRepeatCount() != 0) {
            return super.onKeyDown(i, keyEvent);
        }
        Q.a("ProcessShanYanLogger", "ShanYanOneKeyActivity onKeyDown");
        a(this.i.isBackPressedAvailable());
        return true;
    }

    @Override // android.app.Activity
    protected void onRestart() {
        super.onRestart();
        if (this.v == null || this.i.getAuthBgVideoPath() == null) {
            return;
        }
        w0.a(this.v, this.h, this.i.getAuthBgVideoPath());
    }

    @Override // android.app.Activity
    protected void onResume() {
        super.onResume();
    }

    @Override // android.app.Activity
    protected void onStop() {
        super.onStop();
        C0615u c0615u = this.v;
        if (c0615u != null) {
            c0615u.stopPlayback();
        }
    }

    private void b(String str) {
        OpenLoginAuthCallbaks openLoginAuthCallbaks = this.C;
        if (openLoginAuthCallbaks != null) {
            EnumC0611q enumC0611q = EnumC0611q.SDK_EXCEPTION_CODE;
            openLoginAuthCallbaks.openPageFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c() + str, this.z, this.y, this.w, this.x);
        }
    }

    private void c() {
        if (this.i.getAuthBgVideoPath() != null) {
            m();
        } else if (this.i.getAuthBgGifPath() != null) {
            d();
        } else {
            a(this.n, this.i.getAuthBGImgPath(), "umcsdk_shanyan_authbackground");
        }
    }

    private void d() {
        try {
            F.c().a(getResources().openRawResource(this.h.getResources().getIdentifier(this.i.getAuthBgGifPath(), "drawable", C0616v.g().c(this.h)))).a(this.n);
        } catch (Exception e2) {
            Q.d("ExceptionShanYanLogger", "Error loading GIF background", e2);
        }
    }

    private void e() {
        b();
        a();
    }

    private void f() {
        t0.h().a(this.e);
        this.e.setClickable(true);
        this.e.setText(this.i.getLogBtnText());
        this.e.setTextColor(this.i.getLogBtnTextColor());
        this.e.setTextSize(this.i.isTextSizeIsdp() ? 1 : 2, this.i.getLogBtnTextSize());
        this.e.setTypeface(Typeface.defaultFromStyle(this.i.isLogBtnTextBold() ? 1 : 0));
        g();
        w0.b(this.h, this.e, this.i.getLogBtnOffsetX(), this.i.getLogBtnOffsetY(), this.i.getLogBtnOffsetBottomY(), this.i.getLogBtnWidth(), this.i.getLogBtnHeight());
    }

    private void b() {
        ViewGroup viewGroup = this.s;
        if (viewGroup != null && viewGroup.getParent() != null) {
            this.l.removeView(this.s);
            this.s = null;
        }
        View loadingView = this.i.getLoadingView();
        if (loadingView != null) {
            this.s = (ViewGroup) loadingView;
        } else {
            this.s = (ViewGroup) O.a(this).c("layout_shanyan_loading_item");
        }
        if (this.s != null) {
            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, -1);
            layoutParams.addRule(13);
            this.s.setLayoutParams(layoutParams);
            this.s.setOnClickListener(null);
            this.s.setVisibility(8);
            this.l.addView(this.s);
            this.s.bringToFront();
        }
        t0.h().a(this.s);
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(String str) {
        Q.d("ExceptionShanYanLogger", str);
        S s = new S(this.h);
        EnumC0611q enumC0611q = EnumC0611q.SDK_EXCEPTION_CODE;
        s.getTokenFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c() + str, this.z, this.y, this.w, this.x);
        finish();
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(int i, int i2, String str) {
        AuthPageActionListener authPageActionListener = AbstractC0606l.S;
        if (authPageActionListener != null) {
            authPageActionListener.setAuthPageActionListener(i, i2, str);
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public /* synthetic */ void a(r0 r0Var, View view) {
        if (r0Var.f1997a) {
            finish();
        }
        ShanYanCustomInterface shanYanCustomInterface = r0Var.d;
        if (shanYanCustomInterface != null) {
            shanYanCustomInterface.onClick(this.h, view);
        }
    }

    private void a() {
        ViewGroup viewGroup = this.u;
        if (viewGroup != null && viewGroup.getParent() != null) {
            this.n.removeView(this.u);
            this.u = null;
        }
        ViewGroup viewGroup2 = (ViewGroup) this.i.getCustomPrivacyAlertView();
        Q.a("UIShanYanLogger", "customView", Boolean.valueOf(viewGroup2 == null));
        if (viewGroup2 != null) {
            this.u = viewGroup2;
            RelativeLayout.LayoutParams layoutParams = new RelativeLayout.LayoutParams(-1, -1);
            layoutParams.addRule(13);
            this.u.setLayoutParams(layoutParams);
            this.u.setOnClickListener(null);
            this.u.setVisibility(8);
            this.n.addView(this.u);
            this.u.bringToFront();
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(View view, Drawable drawable, String str) {
        if (drawable != null) {
            if (view instanceof ImageView) {
                ((ImageView) view).setImageDrawable(drawable);
                return;
            } else {
                view.setBackground(drawable);
                return;
            }
        }
        int identifier = this.h.getResources().getIdentifier(str, "drawable", C0616v.g().c(this.h));
        if (identifier != 0) {
            if (view instanceof ImageView) {
                ((ImageView) view).setImageResource(identifier);
            } else {
                view.setBackgroundResource(identifier);
            }
        }
    }

    /* JADX INFO: Access modifiers changed from: private */
    public void a(boolean z) {
        S s = new S(this.h);
        EnumC0611q enumC0611q = EnumC0611q.USER_CANCEL_CODE;
        s.getTokenFailed(enumC0611q.d(), enumC0611q.b(), enumC0611q.e(), enumC0611q.c(), this.z, this.y, this.w, this.x);
        if (z) {
            finish();
        }
    }
}
