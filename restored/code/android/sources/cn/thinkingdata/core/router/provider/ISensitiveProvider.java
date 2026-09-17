package cn.thinkingdata.core.router.provider;

import android.content.Context;
import cn.thinkingdata.core.router.provider.callback.ISensitivePropertiesCallBack;

/* JADX INFO: loaded from: classes.dex */
public interface ISensitiveProvider extends IProvider {
    void getSensitiveProperties(Context context, ISensitivePropertiesCallBack iSensitivePropertiesCallBack);
}
