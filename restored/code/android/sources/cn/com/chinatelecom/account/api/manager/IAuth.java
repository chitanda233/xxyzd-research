package cn.com.chinatelecom.account.api.manager;

import cn.com.chinatelecom.account.api.CtSetting;
import cn.com.chinatelecom.account.api.ResultListener;

/* JADX INFO: loaded from: classes.dex */
public interface IAuth {
    void requestPreLogin4G(String str, CtSetting ctSetting, int i, ResultListener resultListener);

    void requestPreLoginBoth(String str, CtSetting ctSetting, int i, ResultListener resultListener);
}
