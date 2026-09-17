package cn.thinkingdata.analytics.h;

import cn.thinkingdata.analytics.TDConfig;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public interface h {

    public static class a extends Exception {
        a(String str) {
            super(str);
        }
    }

    String a(TDConfig tDConfig, String str, Map<String, String> map);
}
