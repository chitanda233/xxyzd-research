package com.baidu.mobads.sdk.internal;

import android.widget.RelativeLayout;
import com.baidu.mobads.sdk.api.IOAdEvent;
import com.baidu.mobads.sdk.api.IOAdEventListener;
import com.baidu.mobads.sdk.api.ShakeViewContainer;
import java.util.Map;

/* JADX INFO: loaded from: classes.dex */
public class al implements ShakeViewContainer {

    /* JADX INFO: renamed from: a, reason: collision with root package name */
    private RelativeLayout f414a;
    private IOAdEventListener b;

    public al(RelativeLayout relativeLayout, IOAdEventListener iOAdEventListener) {
        this.f414a = relativeLayout;
        this.b = iOAdEventListener;
    }

    @Override // com.baidu.mobads.sdk.api.ShakeViewContainer
    public RelativeLayout getContainer() {
        return this.f414a;
    }

    @Override // com.baidu.mobads.sdk.api.ShakeViewContainer
    public void resume() {
        IOAdEventListener iOAdEventListener = this.b;
        if (iOAdEventListener != null) {
            iOAdEventListener.run(new a("resume"));
        }
    }

    @Override // com.baidu.mobads.sdk.api.ShakeViewContainer
    public void pause() {
        IOAdEventListener iOAdEventListener = this.b;
        if (iOAdEventListener != null) {
            iOAdEventListener.run(new a(com.sigmob.sdk.base.common.a.j));
        }
    }

    @Override // com.baidu.mobads.sdk.api.ShakeViewContainer
    public void destroy() {
        IOAdEventListener iOAdEventListener = this.b;
        if (iOAdEventListener != null) {
            iOAdEventListener.run(new a(com.sigmob.sdk.mraid.g.b));
        }
        this.b = null;
        this.f414a = null;
    }

    private static class a implements IOAdEvent {

        /* JADX INFO: renamed from: a, reason: collision with root package name */
        private final String f415a;

        @Override // com.baidu.mobads.sdk.api.IOAdEvent
        public int getCode() {
            return 0;
        }

        @Override // com.baidu.mobads.sdk.api.IOAdEvent
        public Map<String, Object> getData() {
            return null;
        }

        @Override // com.baidu.mobads.sdk.api.IOAdEvent
        public Object getTarget() {
            return null;
        }

        @Override // com.baidu.mobads.sdk.api.IOAdEvent
        public String getType() {
            return "native_shake";
        }

        @Override // com.baidu.mobads.sdk.api.IOAdEvent
        public void setTarget(Object obj) {
        }

        a(String str) {
            this.f415a = str;
        }

        @Override // com.baidu.mobads.sdk.api.IOAdEvent
        public String getMessage() {
            return this.f415a;
        }
    }
}
