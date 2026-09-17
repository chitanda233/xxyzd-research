package cn.thinkingdata.analytics;

import android.text.TextUtils;
import cn.thinkingdata.analytics.h.k;
import cn.thinkingdata.core.utils.TDLog;
import org.json.JSONObject;

/* JADX INFO: loaded from: classes.dex */
public class TDFirstEvent extends TDEventModel {
    private static final String TAG = "ThinkingAnalytics.TDUniqueEvent";
    private String mExtraValue;

    public TDFirstEvent(String str, JSONObject jSONObject) {
        super(str, jSONObject);
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsEvent
    k getDataType() {
        return k.TRACK;
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsEvent
    String getExtraField() {
        return "#first_check_id";
    }

    @Override // cn.thinkingdata.analytics.ThinkingAnalyticsEvent
    String getExtraValue() {
        return this.mExtraValue;
    }

    public void setFirstCheckId(String str) {
        if (TextUtils.isEmpty(str)) {
            TDLog.w(TAG, "Invalid firstCheckId. Use device Id");
        } else {
            this.mExtraValue = str;
        }
    }
}
