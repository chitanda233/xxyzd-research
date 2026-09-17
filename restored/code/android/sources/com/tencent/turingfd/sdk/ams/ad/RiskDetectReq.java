package com.tencent.turingfd.sdk.ams.ad;

import java.util.Map;

/* JADX INFO: loaded from: classes4.dex */
public final class RiskDetectReq extends Lemon {

    public static final class Builder {
        public RiskDetectReq build() {
            return new RiskDetectReq(this);
        }

        public Builder cache(boolean z) {
            return this;
        }

        public Builder forceDowngrade() {
            return this;
        }

        public Builder inputParam(Map<Integer, String> map) {
            return this;
        }

        public Builder packTimeoutMillis(int i) {
            return this;
        }

        public Builder reqTimeoutMillis(int i) {
            return this;
        }

        public Builder sourceInfo(Map<String, String> map) {
            return this;
        }
    }

    public RiskDetectReq(Builder builder) {
    }
}
