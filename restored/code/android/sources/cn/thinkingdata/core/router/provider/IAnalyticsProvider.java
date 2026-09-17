package cn.thinkingdata.core.router.provider;

import android.util.Pair;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public interface IAnalyticsProvider extends IProvider {
    Map<String, Object> getAnalyticsProperties(String str);

    Pair<Long, Boolean> getCurrentTimeStamp();

    String getDistinctId(String str);

    String getLoginId(String str);
}
