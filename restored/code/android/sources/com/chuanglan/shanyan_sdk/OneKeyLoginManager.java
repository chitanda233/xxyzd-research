package com.chuanglan.shanyan_sdk;

import android.app.Activity;
import android.content.Context;
import android.widget.CheckBox;
import com.chuanglan.shanyan_sdk.listener.ActionListener;
import com.chuanglan.shanyan_sdk.listener.AuthenticationExecuteListener;
import com.chuanglan.shanyan_sdk.listener.GetPhoneInfoListener;
import com.chuanglan.shanyan_sdk.listener.InitListener;
import com.chuanglan.shanyan_sdk.listener.LoginActivityStatusListener;
import com.chuanglan.shanyan_sdk.listener.OnClickPrivacyListener;
import com.chuanglan.shanyan_sdk.listener.OneKeyLoginListener;
import com.chuanglan.shanyan_sdk.listener.OneKeyLoginLogListener;
import com.chuanglan.shanyan_sdk.listener.OpenLoginAuthListener;
import com.chuanglan.shanyan_sdk.listener.PricacyOnClickListener;
import com.chuanglan.shanyan_sdk.tool.ShanYanUIConfig;
import com.cmic.gen.sdk.auth.GenAuthnHelper;
import com.unicom.online.account.shield.UniAccountHelper;

/* JADX INFO: loaded from: classes2.dex */
public class OneKeyLoginManager {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private static volatile OneKeyLoginManager f1952a;

    private OneKeyLoginManager() {
    }

    public static OneKeyLoginManager getInstance() {
        if (f1952a == null) {
            synchronized (OneKeyLoginManager.class) {
                if (f1952a == null) {
                    f1952a = new OneKeyLoginManager();
                }
            }
        }
        return f1952a;
    }

    public void checkProcessesEnable(boolean z) {
        t0.h().a(z);
    }

    public void clearScripCache(Context context) {
        t0.h().c();
    }

    public int currentSimCounts(Context context) {
        Q.a("ProcessShanYanLogger", "getSimCount");
        return C0616v.g().e(context.getApplicationContext());
    }

    public void finishAuthActivity() {
        t0.h().f();
    }

    public Activity getAuthActivity() {
        return t0.h().g();
    }

    public void getIEnable(boolean z) {
        t0.h().c(z);
    }

    @Deprecated
    public void getImEnable(boolean z) {
        t0.h().b(z);
    }

    public void getMaEnable(boolean z) {
        Q.a("ProcessShanYanLogger", "getMacEnable", Boolean.valueOf(z));
    }

    public void getOaidEnable(boolean z) {
        t0.h().d(z);
    }

    public String getOperatorInfo(Context context) {
        Q.a("ProcessShanYanLogger", "getOperatorInfo");
        return t0.h().b(context);
    }

    public String getOperatorType(Context context) {
        Q.a("ProcessShanYanLogger", "getOperatorType");
        return C0616v.g().b(context.getApplicationContext());
    }

    public void getPhoneInfo(GetPhoneInfoListener getPhoneInfoListener) {
        t0.h().a(getPhoneInfoListener);
    }

    @Deprecated
    public boolean getPreIntStatus() {
        return t0.h().i();
    }

    public CheckBox getPrivacyCheckBox() {
        return t0.h().j();
    }

    public boolean getScripCache(Context context) {
        Q.a("ProcessShanYanLogger", "getScripCache");
        return t0.h().d(context.getApplicationContext());
    }

    public String getShanYanVersion() {
        Q.a("ProcessShanYanLogger", "getShanYanVersion");
        return "2.3.7.5";
    }

    public void getSiEnable(boolean z) {
        Q.a("ProcessShanYanLogger", "getSiEnable", Boolean.valueOf(z));
    }

    public void getSinbEnable(boolean z) {
        Q.a("ProcessShanYanLogger", "getSinbEnable", Boolean.valueOf(z));
    }

    public void init(Context context, String str, InitListener initListener) {
        t0.h().a(context.getApplicationContext(), str, initListener);
    }

    public void ipv6Enable(boolean z) {
        Q.a("ProcessShanYanLogger", "ipv6Enable", Boolean.valueOf(z));
        AbstractC0606l.P = z;
    }

    public void isReadPhoneStatePermissionEnable(boolean z) {
        t0.h().g(z);
    }

    public void openLoginAuth(boolean z, OpenLoginAuthListener openLoginAuthListener, OneKeyLoginListener oneKeyLoginListener) {
        t0.h().a(z, openLoginAuthListener, oneKeyLoginListener);
    }

    public void performLoginClick() {
        t0.h().k();
    }

    public void putSimCounts(boolean z) {
        Q.a("ProcessShanYanLogger", "putSimCounts", Boolean.valueOf(z));
        AbstractC0606l.O = z;
    }

    public void registerActivityLifecycleCallbacks(Context context) {
        t0.h().e(context);
    }

    public void removeAllListener() {
        t0.h().l();
    }

    public void setActionListener(ActionListener actionListener) {
        t0.h().a(actionListener);
    }

    public void setActivityLifecycleCallbacksEnable(boolean z) {
        t0.h().h(z);
    }

    @Deprecated
    public void setAuthThemeConfig(ShanYanUIConfig shanYanUIConfig) {
        t0.h().a(shanYanUIConfig, shanYanUIConfig, shanYanUIConfig);
    }

    public void setCheckBoxValue(boolean z) {
        t0.h().e(z);
    }

    public void setDebug(boolean z) {
        P.f1953a = z;
        UniAccountHelper.getInstance().setLogEnable(z);
        GenAuthnHelper.setDebugMode(z);
    }

    public void setDeviceInfo(boolean z) {
        Q.a("ProcessShanYanLogger", "setDeviceInfo", Boolean.valueOf(z));
        AbstractC0606l.G = z;
    }

    public void setFullReport(boolean z) {
        Q.a("ProcessShanYanLogger", "setFullReport");
        AbstractC0606l.B = z;
    }

    @Deprecated
    public void setInitDebug(boolean z) {
        P.b = z;
    }

    public void setLoadingVisibility(boolean z) {
        t0.h().f(z);
    }

    public void setLogListener(OneKeyLoginLogListener oneKeyLoginLogListener) {
        Q.a(oneKeyLoginLogListener);
    }

    public void setLoginActivityStatusListener(LoginActivityStatusListener loginActivityStatusListener) {
        t0.h().a(loginActivityStatusListener);
    }

    public void setNetworkInfo(boolean z) {
        Q.a("ProcessShanYanLogger", "setNetworkInfo", Boolean.valueOf(z));
        AbstractC0606l.H = z;
    }

    @Deprecated
    public void setOnClickPrivacyListener(OnClickPrivacyListener onClickPrivacyListener) {
        t0.h().a(onClickPrivacyListener);
    }

    public void setPrivacyOnClickListener(PricacyOnClickListener pricacyOnClickListener) {
        t0.h().a(pricacyOnClickListener);
    }

    public void setPrivacyUrlWhiteList(boolean z, String[] strArr) {
        t0.h().a(z, strArr);
    }

    public void setSimcardInfo(boolean z) {
        Q.a("ProcessShanYanLogger", "setSimcardInfo", Boolean.valueOf(z));
        AbstractC0606l.I = z;
    }

    public void setTimeOutForPreLogin(int i) {
        Q.a("ProcessShanYanLogger", "setTimeOutForPreLogin", Integer.valueOf(i));
        AbstractC0606l.y = i;
    }

    public void startAuthentication(AuthenticationExecuteListener authenticationExecuteListener) {
        t0.h().a(authenticationExecuteListener);
    }

    public void startPrivacyProtocolActivity(Context context, String str, String str2) {
        t0.h().a(context, str, str2);
    }

    public void unregisterActivityLifecycleCallbacks(boolean z) {
        t0.h().i(z);
    }

    public void unregisterOnClickPrivacyListener() {
        t0.h().n();
    }

    public void setAuthThemeConfig(ShanYanUIConfig shanYanUIConfig, ShanYanUIConfig shanYanUIConfig2) {
        t0.h().a(shanYanUIConfig, shanYanUIConfig2, (ShanYanUIConfig) null);
    }
}
